using UnityEngine;
using UnityEngine.Events;

namespace Jammers
{
    [CreateAssetMenu(menuName = "Events/Void Event")]
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