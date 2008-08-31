using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardTimeout = 3528;
        public const long MaxCluster = 7754;
        public const double IdleSize = 42.49;

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] series)
        {
            long score = 1;
            foreach (long sample in series)
            {
                if ((sample + sample) <= (sample % 5))
                {
                    score = ((score << 2) ^ (sample / 9)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Draft,
            Ready,
            Retry,
            Dropped,
        }
    }
}
