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

        //Adds listeners for events being triggered in the InputReader script
        private void OnEnable()
        {
            rb = GetComponent<Rigidbody>();

            //_inputReader.JumpEvent += OnJumpInitiated;
            //_inputReader.JumpCanceledEvent += OnJumpCanceled;
            _inputReader.MoveEvent += OnMove;
            //_inputReader.StartedRunning += OnStartedRunning;
            //_inputReader.StoppedRunning += OnStoppedRunning;
            //_inputReader.AttackEvent += OnStartedAttack;
            //...
        }

        private void Start()
        {
            SpawnPlayer();
        }

        bool _previousVertically = false;
        bool _previousHorizontal = false;

        private void Update()
        {
            HandleMovement();
            HandleRotation();
        }

        private void HandleMovement()
        {
            // reset direction
            _topDownMovement = Vector3.zero;

            bool horizontal = _inputVector.x != 0;
            bool vertical = _inputVector.y != 0;

            _previousVertically = false;
            _previousHorizontal = false;

            if (horizontal)
            {
                _topDownMovement.x = Mathf.Sign(_inputVector.x);
                _previousHorizontal = true;
                //Debug.Log($"movement x: {_topDownMovement}");
            }
            else if (vertical)
            {
                _previousVertically = true;
                _topDownMovement.z = Mathf.Sign(_inputVector.y);
                //Debug.Log($"movement y: {_topDownMovement}");
            }

            _characterController.Move(_topDownMovement * Time.deltaTime * _speed.Value);
        }

        private void HandleRotation()
        {
        }

        private void SpawnPlayer()
        {
            //Transform spawnLocation = GetSpawnLocation();
            //Protagonist playerInstance = Instantiate(_playerPrefab, spawnLocation.position, spawnLocation.rotation);

            //_playerInstantiatedChannel.RaiseEvent(playerInstance.transform);
            _playerTransformAnchor.Provide(transform); //the CameraSystem will pick this up to frame the player

            //TODO: Probably move this to the GameManager once it's up and running
            _inputReader.EnableGameplayInput();
        }

        private void OnMove(Vector2 movement)
        {
            Debug.Log($"raw input: {movement}");
            _inputVector = movement;
        }
    }
}