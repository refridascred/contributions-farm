using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 57.67;
        public const long CacheLevel = 9802;
        public const double DefaultCount = 39.99;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long TallyStreamMetricOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 5) <= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next window checks value from a seed.</summary>
        public static long IterateWindowChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
