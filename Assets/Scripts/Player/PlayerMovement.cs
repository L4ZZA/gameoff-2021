using System;
using UnityEngine;

namespace Jammers
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Asset References")]
        [SerializeField]
        private InputReader _inputReader = default;
        [SerializeField]
        private TransformAnchor _playerTransformAnchor = default;
        [SerializeField]
        CharacterController _characterController;

        [Header("Settings")]
        [SerializeField]
        FloatVariable _speed;

        Rigidbody rb;
        private Vector2 _inputVector;
        private Vector3 _topDownMovement;
        Vector3 _lastXZForward;

        //Adds listeners for events being triggered in the InputReader script
        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();

            _inputReader.DashEvent += OnDashTriggered;
            //_inputReader.JumpCanceledEvent += OnJumpCanceled;
            _inputReader.MoveEvent += OnMove;
            //_inputReader.AttackEvent += OnStartedAttack;
            //...
        }

        private void OnDashTriggered()
        {
            Debug.Log("Dashed");
        }

        private void Start()
        {
            SpawnPlayer();
        }

        private void Update()
        {
            HandleMovement();
            HandleRotation();
        }

        private void HandleMovement()
        {
            // reset direction
            _topDownMovement = Vector3.zero;

            bool horizontal = Mathf.Abs(_inputVector.x) > 0;
            bool vertical = Mathf.Abs(_inputVector.y) > 0;

            if (horizontal)
            {
                _topDownMovement.x = Mathf.Sign(_inputVector.x);
            }
            if (vertical)
            {
                _topDownMovement.z = Mathf.Sign(_inputVector.y);
            }
            _topDownMovement.Normalize()
            _characterController.Move(_topDownMovement * Time.deltaTime * _speed.Value);
        }

        private void HandleRotation()
        {
            var _xzForward = Vector3.zero;
            _xzForward.x = _inputVector.normalized.x;
            _xzForward.z = _inputVector.normalized.y;

            bool idle = Mathf.Abs(_inputVector.x) == 0 || Mathf.Abs(_inputVector.y) == 0;
            if (idle)
            {
                _xzForward = _lastXZForward;
            }

            transform.forward = _xzForward;
            _lastXZForward = _xzForward;
        }

        private void SpawnPlayer()
        {
            _playerTransformAnchor.Provide(transform); //the CameraSystem will pick this up to frame the player

            //TODO: Probably move this to the GameManager once it's up and running
            _inputReader.EnableGameplayInput();
        }

        private void OnMove(Vector2 movement)
        {
            _inputVector = movement;
        }
    }
}