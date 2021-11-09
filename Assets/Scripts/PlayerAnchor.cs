using UnityEngine;

namespace Jammers
{

    public class PlayerAnchor : MonoBehaviour
    {
        [Header("Asset References")]
        [SerializeField]
        private InputReader _inputReader = default;
        [SerializeField]
        private TransformAnchor _playerTransformAnchor = default;
        private Vector2 _inputVector;

        //Adds listeners for events being triggered in the InputReader script
        private void OnEnable()
        {
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

        private void Update()
        {
            RecalculateMovement();
        }

        private void RecalculateMovement()
        {
            Vector3 pos = transform.position;
            pos.x += _inputVector.x;
            pos.z += _inputVector.y;
            transform.position = pos;
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

            _inputVector = movement;
        }
    }
}