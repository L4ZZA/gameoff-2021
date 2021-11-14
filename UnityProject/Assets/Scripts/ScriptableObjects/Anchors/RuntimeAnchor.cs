using UnityEngine;
using UnityEngine.Events;

namespace Jammers
{
    /// <summary>
    /// A neat way of storing a reference to a unity objects and
    /// make it accessible from any object, without having
    /// to call the costly GetComponent<T>
    /// </summary>
    public abstract class RuntimeAnchorBase<T> : DescriptionBaseSO where T : UnityEngine.Object
    {
        public UnityAction OnAnchorProvided;

        [Header("Debug")]
        [ReadOnly]
        public bool isSet = false; // Any script can check if the transform is null before using it, by just checking this bool

        [ReadOnly]
        [SerializeField]
        private T _value;
        public T Value => _value;

        /// <summary>
        /// Provides the object that we want to keep track of.
        /// </summary>
        /// <param name="value"></param>
        public void Provide(T value)
        {
            if (value == null)
            {
                Debug.LogError("A null value was provided to the " + this.name + " runtime anchor.");
                return;
            }

            _value = value;
            isSet = true;

            if (OnAnchorProvided != null)
            {
                OnAnchorProvided.Invoke();
            }
        }

        public void Unset()
        {
            _value = null;
            isSet = false;
        }

        private void OnDisable()
        {
            Unset();
        }
    }
}