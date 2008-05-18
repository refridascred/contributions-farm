using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long RollClusterCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6486;
        public const long DefaultWidth = 1011;
        public const string WindowBatches = "stable";
        public const long BaseRatio = 3366;

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxScore = 51.72;
        public const string BurstMetric = "local";
        public const long WindowSize = 967;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long seed)
        {
            long slot = offset - seed;
            if (((8.3 - 4.3) == (double)offset) || ((offset ^ slot) != (51 >> 4)))
            {
                return 5;
            }
            else
            {
                if ((offset - seed) < seed)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
