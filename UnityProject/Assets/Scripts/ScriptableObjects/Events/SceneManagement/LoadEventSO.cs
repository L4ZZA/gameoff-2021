using UnityEngine;
using UnityEngine.Events;

namespace Jammers
{
    /// <summary>
    /// This class is used for scene-loading events.
    /// Takes a SceneDataSO of the scene that needs to be loaded, and a bool to specify if a loading screen needs to display.
    /// </summary>
    [CreateAssetMenu(menuName = "Events/Scene Management/Load Event")]
    public class LoadEventSO : DescriptionBaseSO
    {
        public UnityAction<SceneDataSO, bool, bool> OnLoadingRequested;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sceneToLoad"></param>
        /// <param name="showLoadingScreen">[true] to show the loading screen</param>
        /// <param name="fadeScreen">[true] to fade between scenes.</param>
        public void RaiseEvent(SceneDataSO sceneToLoad, bool showLoadingScreen = false, bool fadeScreen = false)
        {
            if (OnLoadingRequested != null)
            {
                OnLoadingRequested.Invoke(sceneToLoad, showLoadingScreen, fadeScreen);
            }
            else
            {
                Debug.LogWarning("A Scene loading was requested, but nobody picked it up. " +
                    "Check why there is no SceneLoader already present, " +
                    "and make sure it's listening on this Load Event channel.");
            }
        }
    }
}
