using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "alpha-edge";
        public const long CacheInterval = 5486;
        public const long StepFilter = 7266;
        public const long DefaultSize = 3525;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                state = ((state << 2) ^ state) % 101;
                if (((sample & 7) < sample) || ((sample - 448) <= sample))
                {
                    state = (state ^ sample) % 65521;
                }
                else
                {
                    state = state - (state & 31);
                }
            }
            return state;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Closed,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 6515;
        public const long IdleWidth = 3715;
        public const double IdleProfile = 54.17;
        public const long LimitProfile = 7001;
    }
}
