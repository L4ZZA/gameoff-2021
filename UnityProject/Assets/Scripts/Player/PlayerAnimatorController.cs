using UnityEngine;

namespace Jammers
{
    public class PlayerAnimatorController : MonoBehaviour
    {
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
    }
}