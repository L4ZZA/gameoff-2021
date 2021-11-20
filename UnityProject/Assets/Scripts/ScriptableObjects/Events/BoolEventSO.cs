using UnityEngine;
using UnityEngine.Events;

namespace Jammers
{
    
    [CreateAssetMenu(menuName = "Events/Bool Event")]
    public class BoolEventSO : DescriptionBaseSO
    {
        public event UnityAction<bool> OnEventRaised;

        public void RaiseEvent(bool value)
        {
            if (OnEventRaised != null)
            {
                OnEventRaised.Invoke(value);
            }
        }
    }
}
