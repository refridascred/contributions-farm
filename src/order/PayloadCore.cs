using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
