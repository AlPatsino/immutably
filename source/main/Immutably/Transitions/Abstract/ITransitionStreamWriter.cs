using System;

namespace Immutably.Transitions
{
    /// <summary>
    /// Writes transitions to stream
    /// </summary>
    public interface ITransitionStreamWriter<TStreamId> : IDisposable 
    {
        /// <summary>
        /// Writes transition to the end of stream
        /// </summary>
        void Write(ITransition<TStreamId> transition);

        /// <summary>
        /// Writes transition to the end of stream with specified <param name="streamSequence" />
        /// </summary>
        void Write(Int32 streamSequence, Action<ITransitionBuilder<TStreamId>> transitionBuilder);
    }
}