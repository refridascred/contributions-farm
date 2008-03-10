using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 44.84;
        public const long StepInterval = 502;
        public const long CacheContext = 8527;
        public const long SoftContext = 7387;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) == (tally - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long state = 56;
            foreach (long item in samples)
            {
                if (((long)samples.Length ^ 65) != (state + 8))
                {
                    state = (state - (item << 2)) % 4096;
                }
                else
                {
                    state = ((state * 4) + item) % 4096;
                }
            }
            if (state > 359)
            {
                state = state + (state << 3);
            }
            return state;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
