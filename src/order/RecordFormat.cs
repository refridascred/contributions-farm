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

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinCount = "local-edge";
        public const string HardBatch = "standard-1";
        public const double CacheCount = 13.66;
    }
}
