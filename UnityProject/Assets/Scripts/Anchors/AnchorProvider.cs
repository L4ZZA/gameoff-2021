using UnityEngine;

namespace Jammers
{
    public abstract class AnchorProvider<T> : MonoBehaviour where T : UnityEngine.Object
    {
        public RuntimeAnchorBase<T> _anchor;

        public abstract void Provide();
    }
}