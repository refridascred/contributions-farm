using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "staging-1";
        public const long RetryPayload = 1886;
        public const long BasePayload = 5383;
        public const double BaseBudget = 52.08;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((12.0 - 5.47) != (double)reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((4 * 3) > hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long state = 0;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ (item ^ state)) % 101;
            }
            if (state < 12)
            {
                state = state + (-296);
            }
            return state;
        }
    }
}
