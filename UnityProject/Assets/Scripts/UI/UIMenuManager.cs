using System;
using System.Collections;
using UnityEngine;

namespace Jammers
{
    public class UIMenuManager : MonoBehaviour
    {
        [SerializeField]
        InputReader _inputReader;
        [SerializeField]
        float _loadingBuffer;

        [SerializeField]
        UIMainMenu _mainMenu;

        [Header("Broadcasting on")]
        [SerializeField]
        private VoidEventSO _startNewGameEvent = default;
        [SerializeField]
        private VoidEventSO _continueGameEvent = default;
        
        private bool _hasSaveData;

        /// <summary>
        /// Turns the start method into a coroutine, which allows it to run over multiple frames.
        /// https://forum.unity.com/threads/why-change-void-start-to-ienumerator-start.455280/#post-2951443
        /// </summary>
        private IEnumerator Start()
        {
            _inputReader.EnableMenuInput();
            //waiting time for all scenes to be loaded 
            yield return new WaitForSeconds(_loadingBuffer);
            SetupMenuScreen();
        }

        void SetupMenuScreen()
        {
            _hasSaveData = false;
            //_hasSaveData = _saveSystem.LoadSaveDataFromDisk();
            _mainMenu.SetMenuScreen(_hasSaveData);
            _mainMenu.ContinueButtonAction += _continueGameEvent.RaiseEvent;
            _mainMenu.NewGameButtonAction += ButtonStartNewGameClicked;
            _mainMenu.SettingsButtonAction += OpenSettingsScreen;
            _mainMenu.CreditsButtonAction += OpenCreditsScreen;
            _mainMenu.ExitButtonAction += ShowExitConfirmationPopup;
        }

        void ButtonStartNewGameClicked()
        {
            if (!_hasSaveData)
            {
                ConfirmStartNewGame();

            }
            else
            {
                ShowStartNewGameConfirmationPopup();
            }

        }
        void ConfirmStartNewGame()
        {
            _startNewGameEvent.RaiseEvent();
        }

        private void OpenSettingsScreen()
        {
            Debug.Log("Settings screen opened");
        }

        private void OpenCreditsScreen()
        {
            Debug.Log("Credits screen opened");
        }

        private void ShowExitConfirmationPopup()
        {
            Debug.Log("Exit confirmation popup opened");
        }

        void ShowStartNewGameConfirmationPopup()
        {
            Debug.Log("New game confirmation popup opened");
            //_popupPanel.ConfirmationResponseAction += StartNewGamePopupResponse;
            //_popupPanel.ClosePopupAction += HidePopup;

            //_popupPanel.gameObject.SetActive(true);
            //_popupPanel.SetPopup(PopupType.NewGame);

        }
    }
}