using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

namespace Jammers
{
    public class SceneDataSO : DescriptionBaseSO
    {
        public string sceneReference; //Used at runtime to load the scene from the right AssetBundle
        //public AudioCueSO musicTrack;

        /// <summary>
        /// Used by the SceneSelector tool to discern what type of scene it needs to load
        /// </summary>
        public enum GameSceneType
        {
            //Playable scenes
            Location, //SceneSelector tool will also load PersistentManagers and Gameplay
            Menu, //SceneSelector tool will also load Gameplay

            //Special scenes
            Initialisation,
            PersistentManagers,
            Gameplay,

            //Work in progress scenes that don't need to be played
            Art,
        }
    }

}