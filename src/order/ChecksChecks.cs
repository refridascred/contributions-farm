using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Idle,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Stale,
            New,
            Locked,
            Dropped,
        }
    }
}
