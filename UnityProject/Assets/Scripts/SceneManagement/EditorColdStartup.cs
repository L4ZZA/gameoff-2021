using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jammers
{
    /// <summary>
    /// Allows a "cold start" in the editor, when pressing Play and not passing from the Initialisation scene.
    /// </summary> 
    public class EditorColdStartup : MonoBehaviour
    {
#if UNITY_EDITOR
        [SerializeField] private SceneDataSO _thisSceneSO = default;
        [SerializeField] private SceneDataSO _persistentManagersSO = default;
        [SerializeField] private LoadEventSO _notifyColdStartupChannel = default;
        [SerializeField] private VoidEventSO _onSceneReadyChannel = default;
        //[SerializeField] private SaveSystem _saveSystem = default;

        private bool _isColdStart = false;
        List<AsyncOperation> _unloadingOperations = new List<AsyncOperation>();
        private void Awake()
        {
            bool alreadyLoaded = SceneManager.GetSceneByName(_persistentManagersSO.sceneReference).isLoaded;
            if (!alreadyLoaded)
            {
                _isColdStart = true;
            }
            CreateSaveFileIfNotPresent();
        }

        private void Start()
        {
            if (_isColdStart)
            {
                var t =SceneManager.LoadSceneAsync(_persistentManagersSO.sceneReference, LoadSceneMode.Additive);
                t.completed += LoadEventChannel;
            }
            CreateSaveFileIfNotPresent();
        }

        private void CreateSaveFileIfNotPresent()
        {
            //if (_saveSystem != null && !_saveSystem.LoadSaveDataFromDisk())
            //{
            //    _saveSystem.SetNewGameData();
            //}
        }

        private void LoadEventChannel(AsyncOperation _)
        {
            if (_thisSceneSO != null)
            {
                _notifyColdStartupChannel.RaiseEvent(_thisSceneSO);
                //obj.Result.RaiseEvent(_thisSceneSO);
            }
            else
            {
                //Raise a fake scene ready event, so the player is spawned
                _onSceneReadyChannel.RaiseEvent();
                //When this happens, the player won't be able to move between scenes because the SceneLoader has no conception of which scene we are in
            }
        }
#endif
    }
}