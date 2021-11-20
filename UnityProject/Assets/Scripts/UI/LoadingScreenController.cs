using UnityEngine;

namespace Jammers
{
    public class LoadingScreenController : MonoBehaviour
    {
        [SerializeField] private GameObject _loadingScreen = default;

        [Header("Listening on")]
        [SerializeField] private BoolEventSO _toggleLoadingScreen = default;


        private void OnEnable()
        {
            _toggleLoadingScreen.OnEventRaised += ToggleLoadingScreen;
        }

        private void OnDisable()
        {
            _toggleLoadingScreen.OnEventRaised -= ToggleLoadingScreen;
        }

        private void ToggleLoadingScreen(bool state)
        {
            _loadingScreen.SetActive(state);
        }
    }
}
