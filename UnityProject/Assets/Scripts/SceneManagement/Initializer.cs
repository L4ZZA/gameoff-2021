using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jammers
{
    /// <summary>
    /// Responsible to load the persistent managers scenes 
    /// and then the main menu scene
    /// </summary>
    public class Initializer : MonoBehaviour
    {
        [SerializeField] private SceneDataSO _managersScene = default;
        [SerializeField] private SceneDataSO _menuToLoad = default;

        //[Header("Broadcasting on")]
        //[SerializeField] private AssetReference _menuLoadChannel = default;
        [SerializeField] private LoadEventSO _menuLoadChannel = default;

        private void Start()
        {
            //Load the persistent managers scene
            var operation = SceneManager.LoadSceneAsync(_managersScene.sceneReference, LoadSceneMode.Additive);
            operation.completed += LoadEventChannel;
        }

        private void LoadEventChannel(AsyncOperation obj)
        {
            LoadMainMenu();
        }

        private void LoadMainMenu()
        {
            _menuLoadChannel.RaiseEvent(_menuToLoad, true);

            //Initialization is the only scene in BuildSettings, thus it has index 0
            SceneManager.UnloadSceneAsync(0); 
        }
    }
}