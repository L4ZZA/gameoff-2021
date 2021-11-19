using System;
using UnityEngine;

namespace Jammers
{
    public class PlayerAnimatorController : MonoBehaviour
    {
        [SerializeField]
        InputReader _inputReader;

        [SerializeField]
        Animator _animator;

        [Range(-1,1)]
        public float Horizontal;
        [Range(-1,1)]
        public float Vertical;

        public bool meleeAttack;

        public bool rangeAttack;

        [Header("Parameter Names")]
        public string HorizontalParam;
        public string VerticalParam;
        public string MeleeAttackParam;
        public string RangeAttackParam;

        
		private Vector2 _inputVector;

        private void OnEnable()
        {
			_inputReader.MoveEvent += OnMove;
        }

        private void OnMove(Vector2 input)
        {
            _inputVector = input;
        }

        private void OnDisable()
        {
            
			_inputReader.MoveEvent -= OnMove;
        }

        // Update is called once per frame
        void Update()
        {
            if (_animator)
            {
                _animator.SetFloat(HorizontalParam, Horizontal);
                _animator.SetFloat(VerticalParam, Vertical);

                if (meleeAttack)
                {
                    _animator.SetTrigger(MeleeAttackParam);
                    meleeAttack = false;
                }
                if (rangeAttack)
                {
                    _animator.SetTrigger(RangeAttackParam);
                    rangeAttack = false;
                }
            }
        }

        private void FixedUpdate()
        {
            Horizontal = _inputVector.normalized.x;
            Vertical = _inputVector.normalized.y;
        }
    }
}