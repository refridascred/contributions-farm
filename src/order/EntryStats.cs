using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9009;
        public const double BurstSpan = 58.45;
        public const string MaxSession = "strict-1";
        public const long SoftSession = 7207;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowTimeout = "alpha";
        public const long LimitNotes = 9700;
        public const long BaseNotes = 3434;
        public const long HardNotes = 555;

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 8.94;
        public const string IdleWindow = "cached-v2";
        public const long MinWindow = 7772;
    }
}
