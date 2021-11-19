
namespace Jammers
{
    /// <summary>
    /// Listener of <see cref="IEvent"/> objects
    /// </summary>
    public interface IListener
    {
        /// <summary>
        /// Called when the <see cref="IEvent"/> implementation 
        /// calls the <see cref="IEvent.Raise"/> method.
        /// </summary>
        public void OnEventRaised();
    };
}