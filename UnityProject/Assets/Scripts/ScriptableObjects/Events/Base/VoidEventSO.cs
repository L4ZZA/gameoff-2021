using UnityEngine;
using UnityEngine.Events;

namespace Jammers
{
    /// <summary>
    /// This class is used for Events that have no arguments (Example: Exit game event)
    /// </summary>
    [CreateAssetMenu(menuName = "Events/Base/Void Event")]
    public class VoidEventSO : DescriptionBaseSO
    {
        public UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            if (OnEventRaised != null)
            {
                OnEventRaised.Invoke();
            }
        }
    }
}