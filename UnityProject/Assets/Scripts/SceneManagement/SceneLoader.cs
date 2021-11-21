using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jammers
{
    /// <summary>
    /// This class manages the scene loading and unloading.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private SceneDataSO _gameplayScene = default;
        [SerializeField] private InputReader _inputReader = default;


        [Header("Events listening to")]
        [SerializeField] private LoadEventSO _loadScene = default;
        [SerializeField] private LoadEventSO _loadMenu = default;
        [SerializeField] private LoadEventSO _coldStartupLocation = default;

        [Header("Events triggering on")]
        [SerializeField] private BoolEventSO _toggleLoadingScreen = default;
        [SerializeField] private VoidEventSO _onSceneReady = default; //picked up by the SpawnSystem
        [SerializeField] private FadeEventSO _fadeRequest = default;

        Scene _gameplayManagerSceneInstance;
        private AsyncOperation _loadingOperationHandle;
        private AsyncOperation _gameplayManagerLoadingOpHandle;

        //Parameters coming from scene loading requests
        private SceneDataSO _sceneToLoad;
        private SceneDataSO _currentlyLoadedScene;
        private bool _showLoadingScreen;

        [SerializeField]
        private float _fadeDuration = .5f;
        private bool _isLoading = false; //To prevent a new loading request while already loading a new scene

        private void OnEnable()
        {
            //_loadScene.OnLoadingRequested += LoadScene;
            _loadMenu.OnLoadingRequested += LoadMenu;
#if UNITY_EDITOR
            //_coldStartupLocation.OnLoadingRequested += LocationColdStartup;
#endif

        }
        private void OnDisable()
        {
            //_loadScene.OnLoadingRequested -= LoadScene;
            _loadMenu.OnLoadingRequested -= LoadMenu;
#if UNITY_EDITOR
            //_coldStartupLocation.OnLoadingRequested -= LocationColdStartup;
#endif
        }

#if UNITY_EDITOR
        /// <summary>
        /// This special loading function is only used in the editor, when the developer presses Play in a Location scene, without passing by Initialisation.
        /// </summary>
        private void LocationColdStartup(SceneDataSO currentlyOpenedLocation, bool showLoadingScreen, bool fadeScreen)
        {
            _currentlyLoadedScene = currentlyOpenedLocation;

            if (_currentlyLoadedScene.sceneType == SceneDataSO.GameSceneType.Location)
            {
                StartCoroutine(LoadScene());
            }
        }
#endif
        IEnumerator LoadScene()
        {
            //Gameplay managers is loaded synchronously
            _gameplayManagerLoadingOpHandle = SceneManager.LoadSceneAsync(_gameplayScene.sceneReference, LoadSceneMode.Additive);

            //_gameplayManagerLoadingOpHandle.WaitForCompletion();
            yield return new WaitUntil(() => _gameplayManagerLoadingOpHandle.isDone);

            _gameplayManagerSceneInstance = SceneManager.GetSceneByName(_gameplayScene.sceneReference);
            StartGameplay();
        }

        /// <summary>
        /// This function loads the location scenes passed as array parameter
        /// </summary>
        private void LoadScene(SceneDataSO locationToLoad, bool showLoadingScreen, bool fadeScreen)
        {
            //Prevent a double-loading, for situations where the player falls in two Exit colliders in one frame
            if (_isLoading)
            {
                return;
            }

            _sceneToLoad = locationToLoad;
            _showLoadingScreen = showLoadingScreen;
            _isLoading = true;

            //In case we are coming from the main menu, we need to load the Gameplay manager scene first
            if (_gameplayManagerSceneInstance == null
                || !_gameplayManagerSceneInstance.isLoaded)
            {
                _gameplayManagerLoadingOpHandle = SceneManager.LoadSceneAsync(_gameplayScene.sceneReference, LoadSceneMode.Additive);
                _gameplayManagerLoadingOpHandle.completed += OnGameplayManagersLoaded;
            }
            else
            {
                StartCoroutine(UnloadPreviousScene());
            }
        }

        /// <summary>
        /// Prepares to load the main menu scene, first removing the Gameplay scene 
        /// in case the game is coming back from gameplay to menus.
        /// </summary>
        private void LoadMenu(SceneDataSO menuToLoad, bool showLoadingScreen, bool fadeScreen)
        {
            //Prevent a double-loading, for situations where the player falls in two Exit colliders in one frame
            if (_isLoading)
            {
                return;
            }

            _sceneToLoad = menuToLoad;
            _showLoadingScreen = showLoadingScreen;
            _isLoading = true;

            //In case we are coming from a Location back to the main menu, we need to get rid of the persistent Gameplay manager scene
            if (_gameplayManagerSceneInstance != null
                && _gameplayManagerSceneInstance.isLoaded)
            {
                //SceneManager.UnloadSceneAsync(_gameplayManagerLoadingOpHandle);
            }

            StartCoroutine(UnloadPreviousScene());
        }

        private void StartGameplay()
        {
            _onSceneReady.RaiseEvent(); //Spawn system will spawn the PigChef in a gameplay scene
        }

        private void ExitGame()
        {
            Application.Quit();
            Debug.Log("Exit!");
        }

        /// <summary>
        /// In both Location and Menu loading, this function takes care of removing previously loaded scenes.
        /// </summary>
        private IEnumerator UnloadPreviousScene()
        {
            _inputReader.DisableAllInput();
            _fadeRequest.FadeOut(_fadeDuration);

            yield return new WaitForSeconds(_fadeDuration);

            // would be null if the game was started in Initialisation
            if (_currentlyLoadedScene != null)
            {
                SceneManager.UnloadSceneAsync(_currentlyLoadedScene.sceneReference);
            }

            LoadNewScene();
        }

        /// <summary>
        /// Kicks off the asynchronous loading of a scene, either menu or Location.
        /// </summary>
        private void LoadNewScene()
        {
            if (_showLoadingScreen)
            {
                _toggleLoadingScreen.RaiseEvent(true);
            }

            _loadingOperationHandle = SceneManager.LoadSceneAsync(_sceneToLoad.sceneReference, LoadSceneMode.Additive);
            _loadingOperationHandle.completed += OnNewSceneLoaded;
        }

        private void OnNewSceneLoaded(AsyncOperation obj)
        {
            //Save loaded scenes (to be unloaded at next load request)
            _currentlyLoadedScene = _sceneToLoad;

            Scene s = SceneManager.GetSceneByName(_sceneToLoad.sceneReference);
            SceneManager.SetActiveScene(s);
            LightProbes.TetrahedralizeAsync();

            _isLoading = false;

            if (_showLoadingScreen)
            {
                _toggleLoadingScreen.RaiseEvent(false);
            }

            _fadeRequest.FadeIn(_fadeDuration);

            StartGameplay();
        }
        private void OnGameplayManagersLoaded(AsyncOperation obj)
        {
            //_gameplayManagerSceneInstance = _gameplayManagerLoadingOpHandle;

            StartCoroutine(UnloadPreviousScene());
        }
    }
}