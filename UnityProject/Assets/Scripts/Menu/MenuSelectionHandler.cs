using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Jammers
{
    public class MenuSelectionHandler : MonoBehaviour
    {
        [SerializeField] private InputReader _inputReader;
        [SerializeField] [ReadOnly] private GameObject _defaultSelection;
        [SerializeField] [ReadOnly] private GameObject _currentSelection;
        [SerializeField] [ReadOnly] private GameObject _mouseSelection;

        private void OnEnable()
        {
            _inputReader.MenuMouseMoveEvent += HandleMoveCursor;
            _inputReader.MoveSelectionEvent += HandleMoveSelection;

            StartCoroutine(SelectDefault());
        }

        private void OnDisable()
        {
            _inputReader.MenuMouseMoveEvent -= HandleMoveCursor;
            _inputReader.MoveSelectionEvent -= HandleMoveSelection;
        }

        private void Update()
        {
            if ((EventSystem.current != null) &&
                (EventSystem.current.currentSelectedGameObject == null) &&
                (_currentSelection != null))
            {
                EventSystem.current.SetSelectedGameObject(_currentSelection);
            }
        }

        /// <summary>
        /// Fired by keyboard and gamepad inputs. Current selected UI element will be the ui Element that was selected
        /// when the event was fired. The _currentSelection is updated later on, after the EventSystem moves to the
        /// desired UI element, the UI element will call into UpdateSelection()
        /// </summary>
        private void HandleMoveSelection()
        {
            Cursor.visible = false;

            // Handle case where no UI element is selected because mouse left selectable bounds
            if (EventSystem.current.currentSelectedGameObject == null)
            {
                EventSystem.current.SetSelectedGameObject(_currentSelection);
            }
        }

        private void HandleMoveCursor()
        {
            if (_mouseSelection != null)
            {
                EventSystem.current.SetSelectedGameObject(_mouseSelection);
            }

            Cursor.visible = true;
        }

        /// <summary>
        /// Highlights the default element
        /// </summary>
        private IEnumerator SelectDefault()
        {
            yield return new WaitForSeconds(.03f); // Necessary wait otherwise the highlight won't show up

            if (_defaultSelection != null)
            {
                UpdateSelection(_defaultSelection);
            }
        }

        // TODO: figure out when to use it..
        public void UpdateDefault(GameObject newDefault)
        {
            _defaultSelection = newDefault;
        }

        /// <summary>
        /// Fired by gamepad or keyboard navigation inputs
        /// </summary>
        /// <param name="uiElement"></param>
        public void UpdateSelection(GameObject uiElement)
        {
            var multiInputElement = uiElement.GetComponent<MultiInputSelectableElement>();
            var multiInputButton = uiElement.GetComponent<MultiInputButton>();

            if (multiInputElement != null || multiInputButton != null)
            {
                _mouseSelection = uiElement;
                _currentSelection = uiElement;
            }
        }


        public void HandleMouseEnter(GameObject uiElement)
        {
            _mouseSelection = uiElement;
            EventSystem.current.SetSelectedGameObject(uiElement);
        }

        public void HandleMouseExit(GameObject uiElement)
        {
            if (EventSystem.current.currentSelectedGameObject != uiElement)
            {
                return;
            }

            // keep selecting the last thing the mouse has selected 
            _mouseSelection = null;
            EventSystem.current.SetSelectedGameObject(_currentSelection);
        }

        /// <summary>
        /// Method interactable UI elements should call on Submit interaction 
        /// to determine whether to continue or not.
        /// </summary>
        /// <returns></returns>
        public bool AllowsSubmit()
        {
            // if LeftMouseButton is not down, there is no edge case to handle, allow the event to continue
            return !_inputReader.LeftMouseDown()
                   // if we know mouse & keyboard are on different elements, do not allow interaction to continue
                   || _mouseSelection != null && _mouseSelection == _currentSelection;
        }
    }
}