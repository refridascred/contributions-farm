using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Retry,
            Active,
            Stale,
            Dropped,
        }
    }
}
