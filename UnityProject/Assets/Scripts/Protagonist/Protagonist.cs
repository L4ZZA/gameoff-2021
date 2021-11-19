using System;
using UnityEngine;

namespace Jammers
{
	[RequireComponent(typeof(CharacterController))]
	public class Protagonist : MonoBehaviour
	{
		[SerializeField] private InputReader _inputReader = default;
		[SerializeField] private TransformAnchor _gameplayCameraTransform = default;

		private Vector2 _inputVector;
		private float _previousSpeed;

		//These fields are read and manipulated by the StateMachine actions
		[NonSerialized] public bool dashInput;
		[NonSerialized] public bool attackInput;
		[NonSerialized] public Vector3 movementInput; //Initial input coming from the Protagonist script
		[NonSerialized] public Vector3 movementVector; //Final movement vector, manipulated by the StateMachine actions
		[NonSerialized] public ControllerColliderHit lastHit;
		[NonSerialized] public bool isRunning; // Used when using the keyboard to run, brings the normalised speed to 1

		public const float GRAVITY_MULTIPLIER = 5f;
		public const float MAX_FALL_SPEED = -50f;
		public const float MAX_RISE_SPEED = 100f;
		public const float GRAVITY_COMEBACK_MULTIPLIER = .03f;
		public const float GRAVITY_DIVIDER = .6f;
		public const float AIR_RESISTANCE = 5f;

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			lastHit = hit;
		}

		//Adds listeners for events being triggered in the InputReader script
		private void OnEnable()
		{
			_inputReader.DashEvent += OnJumpInitiated;
			_inputReader.DashCanceledEvent += OnJumpCanceled;
			_inputReader.MoveEvent += OnMove;
			_inputReader.AttackEvent += OnStartedAttack;
			//...
		}

		//Removes all listeners to the events coming from the InputReader script
		private void OnDisable()
		{
			_inputReader.DashEvent -= OnJumpInitiated;
			_inputReader.DashCanceledEvent -= OnJumpCanceled;
			_inputReader.MoveEvent -= OnMove;
			_inputReader.AttackEvent -= OnStartedAttack;
			//...
		}

		private void Update()
		{
			RecalculateMovement();
		}

		private void RecalculateMovement()
		{
			float targetSpeed;
			Vector3 adjustedMovement;

			if (_gameplayCameraTransform.isSet)
			{
				//Get the two axes from the camera and flatten them on the XZ plane
				Vector3 cameraForward = _gameplayCameraTransform.value.forward;
				cameraForward.y = 0f;
				Vector3 cameraRight = _gameplayCameraTransform.value.right;
				cameraRight.y = 0f;

				//Use the two axes, modulated by the corresponding inputs, and construct the final vector
				adjustedMovement = cameraRight.normalized * _inputVector.x +
					cameraForward.normalized * _inputVector.y;
			}
			else
			{
				//No CameraManager exists in the scene, so the input is just used absolute in world-space
				Debug.LogWarning("No gameplay camera in the scene. Movement orientation will not be correct.");
				adjustedMovement = new Vector3(_inputVector.x, 0f, _inputVector.y);
			}

			//Fix to avoid getting a Vector3.zero vector, which would result in the player turning to x:0, z:0
			if (_inputVector.sqrMagnitude == 0f)
				adjustedMovement = transform.forward * (adjustedMovement.magnitude + .01f);

			//Accelerate/decelerate
			targetSpeed = Mathf.Clamp01(_inputVector.magnitude);
			if (targetSpeed > 0f)
			{
				// This is used to set the speed to the maximum if holding the Shift key,
				// to allow keyboard players to "run"
				if (isRunning)
					targetSpeed = 1f;

				if (attackInput)
					targetSpeed = .05f;
			}
			targetSpeed = Mathf.Lerp(_previousSpeed, targetSpeed, Time.deltaTime * 4f);

			movementInput = adjustedMovement.normalized * targetSpeed;

			_previousSpeed = targetSpeed;
		}

		//---- EVENT LISTENERS ----

		private void OnMove(Vector2 movement)
		{

			_inputVector = movement;
		}

		private void OnJumpInitiated()
		{
			dashInput = true;
		}

		private void OnJumpCanceled()
		{
			dashInput = false;
		}

		private void OnStartedAttack() => attackInput = true;

		// Triggered from Animation Event
		public void ConsumeAttackInput() => attackInput = false;
	}
}