using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MinCount = "open-1";
        public const long BurstMetric = 3864;
        public const string IdleCount = "cached-v2";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "primary-edge";
        public const string MinBatches = "standard-edge";
        public const double HardBatches = 46.92;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((0.1 * 2.0) >= (double)count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
