
namespace Jammers
{
    public interface IEvent
    {
        /// <summary>
        /// Notifies all the registered listeners.
        /// </summary>
        public void Raise();

        /// <summary>
        /// Subscribe the given listener for notifications.
        /// </summary>
        /// <param name="listener"></param>
        public void Register(IListener listener);

        /// <summary>
        /// Stops notifying the given listener.
        /// </summary>
        /// <param name="listener"></param>
        public void Unregister(IListener listener);
    }

}