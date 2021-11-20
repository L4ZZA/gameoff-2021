using System;
using System.Collections;
using UnityEngine;

namespace Jammers
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField]
        InputReader _inputReader;
        [SerializeField]
        float _loadingBuffer;

	    /// <summary>
        /// Turns the start method into a coroutine, which allows it to run over multiple frames.
        /// https://forum.unity.com/threads/why-change-void-start-to-ienumerator-start.455280/#post-2951443
        /// </summary>
        private IEnumerator Start()
        {
		    _inputReader.EnableMenuInput();
            //waiting time for all scenes to be loaded 
		    yield return new WaitForSeconds(_loadingBuffer); 
		    SetMenuScreen();
        }

        private void SetMenuScreen()
        {
        }
    }
}