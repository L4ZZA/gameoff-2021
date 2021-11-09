using System;
using UnityEngine;

namespace Jammers
{
    public class TopDownCameraController : MonoBehaviour
    {
        public InputReader inputReader;
        public Camera mainCamera;

        public float yPosition;

        [SerializeField]
        private TransformAnchor _cameraTransformAnchor = default;
        [SerializeField]
        private TransformAnchor _protagonistTransformAnchor = default;

        private void OnEnable()
        {
            _protagonistTransformAnchor.OnAnchorProvided += SetupProtagonistVirtualCamera;
            _cameraTransformAnchor.Provide(mainCamera.transform);
        }

        private void Update()
        {
            if (_protagonistTransformAnchor.isSet)
            {
                var camPos = mainCamera.transform.position;
                var playerPos = _protagonistTransformAnchor.Value.position;
                camPos.x = playerPos.x;
                camPos.z = playerPos.z;
                mainCamera.transform.position = camPos;
            }
        }

        private void OnEnableMouseControlCamera()
        {
            throw new NotImplementedException();
        }

        private void OnDisableMouseControlCamera()
        {
            throw new NotImplementedException();
        }

        private void SetupProtagonistVirtualCamera()
        {
            var rotation = new Vector3(90, 0, 0);
            Vector3 p = _protagonistTransformAnchor.Value.position;
            p.y = yPosition;

            mainCamera.transform.position = p;
            mainCamera.transform.rotation = Quaternion.Euler(rotation);

        }
    }
}