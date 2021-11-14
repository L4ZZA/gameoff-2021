using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jammers
{
    public class ToggleMenu : MonoBehaviour
    {
        public InputReader input;
        public GameObject menu;
        bool paused;
        private void OnEnable()
        {
            input.MenuPauseEvent += OnPause;
            input.MenuCloseEvent += OnClose;
        }

        private void OnDisable()
        {
            input.MenuPauseEvent -= OnPause;
            input.MenuCloseEvent -= OnClose;
        }

        private void OnPause()
        {
            paused = true;
            UpdateState();
        }

        private void OnClose()
        {
            paused = false;
            UpdateState();
        }

        void UpdateState()
        {
            Time.timeScale = paused ? 0 : 1;
            menu.SetActive(paused);
            if (paused)
            {
                input.EnableMenuInput();
            }
            else
            {
                input.EnableGameplayInput();
            }
        }
    }
}
