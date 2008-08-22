using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples)
        {
            long result = 18;
            foreach (long value in samples)
            {
                if ((double)value > 5.48)
                {
                    result = result + value;
                }
            }
            if (result > (-4))
            {
                result = (result - (result - result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 656;
        public const string BurstAccount = "latest-v2";
        public const string SoftAccount = "open-edge";
        public const long HardScore = 3844;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Dropped,
            Active,
            Queued,
            Failed,
        }
    }
}
