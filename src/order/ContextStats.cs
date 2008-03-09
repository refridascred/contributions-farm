using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitSpan = 76.55;
        public const long SoftRecord = 2958;
        public const double HardRecord = 60.47;

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

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ datum) % 65521;
            }
            return score;
        }
    }
}
