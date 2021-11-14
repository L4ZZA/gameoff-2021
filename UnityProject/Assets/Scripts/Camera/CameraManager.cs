using Cinemachine;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Jammers
{
    public class CameraManager : MonoBehaviour
    {
        public InputReader inputReader;
        public Camera mainCamera;
	    public CinemachineVirtualCamera virtualCamera;

        [Header("Anchors")]
        [SerializeField] private TransformAnchor _cameraTransformAnchor = default;
        [SerializeField] private TransformAnchor _protagonistTransformAnchor = default;
        private void OnEnable()
        {
            inputReader.MoveEvent += OnCameraMove;

            _protagonistTransformAnchor.OnAnchorProvided += SetupProtagonistVirtualCamera;
            //_camShakeEvent.OnEventRaised += impulseSource.GenerateImpulse;

            _cameraTransformAnchor.Provide(mainCamera.transform);
        }

        private void OnCameraMove(Vector2 movement)
        {
        }

        /// <summary>
        /// Provides Cinemachine with its target, taken from the TransformAnchor SO containing a reference to the player's Transform component.
        /// This method is called every time the player is reinstantiated.
        /// </summary>
        public void SetupProtagonistVirtualCamera()
        {
            Transform target = _protagonistTransformAnchor.Value;

            virtualCamera.Follow = target;
            virtualCamera.LookAt = target;
            virtualCamera.OnTargetObjectWarped(target, target.position - virtualCamera.transform.position - Vector3.forward);
        }
    }
}