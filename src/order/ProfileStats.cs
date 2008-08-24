using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches + matches) == ((long)readings.Length + 31)) && ((matches - 61) != ((-32) & 15)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 80.55;
        public const double CacheBudget = 92.39;
        public const string BurstTools = "latest-1";
        public const double StepScore = 89.83;
        public const long BaseTools = 1556;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples, long limit)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                if (limit <= (limit & 255))
                {
                    state = (state - (state ^ entry)) % 101;
                }
            }
            if (state < 100)
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 1000;
        }
    }
}
