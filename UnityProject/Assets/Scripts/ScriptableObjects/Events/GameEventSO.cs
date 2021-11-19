using System.Collections.Generic;

namespace Jammers
{

    public class GameEventSO : DescriptionBaseSO, IEvent
    {
        /// <summary>
        /// The list of listeners that this event will notify when raised.
        /// </summary>
        private readonly List<IListener> _eventListeners = new List<IListener>();

        public void Raise()
        {
            // raise event backwards 
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
            {
                _eventListeners[i].OnEventRaised();
            }
        }

        public void Register(IListener listener)
        {
            if (!_eventListeners.Contains(listener))
            {
                _eventListeners.Add(listener);
            }
        }

        public void Unregister(IListener listener)
        {
            if (_eventListeners.Contains(listener))
            {
                _eventListeners.Remove(listener);
            }
        }
    }
}