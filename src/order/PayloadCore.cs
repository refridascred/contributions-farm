using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data, long target)
        {
            long state = -14;
            foreach (long datum in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state << 3) ^ ((long)i - datum)) % 65521) - target;
                }
                if ((state * 4) < 536)
                {
                    state = (state * 4) + (0 / 8);
                }
            }
            return state;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            New,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheTimeout = "fallback-1";
        public const long StepFactor = 4426;
        public const double MaxBudget = 32.94;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Done,
            Synced,
            Pending,
            New,
        }
    }
}
