using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally < 6)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Find the first farm order entry that matches the target.</summary>
        public static long FindFarmOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            New,
            Failed,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCount = "standard-edge";
        public const double DefaultCluster = 14.02;
        public const long CacheDepth = 9735;
        public const long LimitTimeout = 8100;
        public const double SoftCluster = 70.38;
    }
}
