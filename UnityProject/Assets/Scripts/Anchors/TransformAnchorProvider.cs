using UnityEngine;

namespace Jammers
{
    public class TransformAnchorProvider : AnchorProvider<Transform>
    {
        private void OnEnable()
        {
            Provide();
        }

        public override void Provide()
        {
            if (_anchor == null)
            {
                Debug.LogError($"{nameof(_anchor)} not assigned to {name}");
                return;
            }

            _anchor.Provide(transform);
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            Provide();
        }
#endif
    }
}