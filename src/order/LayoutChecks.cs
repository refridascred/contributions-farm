using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha-edge";
        public const string BurstSchema = "stable";
        public const long StepWidth = 388;
        public const long StepSchema = 896;

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftTimeout = 7772;
        public const long DefaultSchema = 3841;
        public const long IdleRatio = 6673;
        public const long HardWidth = 1436;

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = (ratio + (offset * 8.96)) - weight;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (20.0 - offset);
        }
    }
}
