using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jammers
{

    public class ToggleMenu : MonoBehaviour
    {
        public InputReader _inputReader;
        public GameObject _menuToToggle;
        bool _paused;

        private void OnEnable()
        {
            _inputReader.MenuPauseEvent += Pause;
            _inputReader.MenuUnpauseEvent += UnPause;
        }

        private void UpdateState()
        {
            Time.timeScale = _paused ? 0 : 1;
            _menuToToggle.SetActive(_paused);
            if (_paused)
            {
                _inputReader.EnableMenuInput();
            }
            else
            {
            _inputReader.EnableGameplayInput();
            }
        }

        private void OnDisable()
        {
            _inputReader.MenuPauseEvent -= Pause;
            _inputReader.MenuUnpauseEvent -= UnPause;
        }

        private void Pause()
        {
            _paused = true;
            UpdateState();
        }

        private void UnPause()
        {
            _paused = false;
            UpdateState();
        }
    }
}