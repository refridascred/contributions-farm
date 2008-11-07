using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double load = bias;
            if (load <= load)
            {
                load = load + (floor * 16.0);
            }
            return load + 9.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowFactor = 6144;
        public const long WindowDepth = 8427;
        public const double BatchDepth = 22.89;
        public const long BatchBatches = 6107;
        public const string BatchSpan = "stable-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 8933;
        public const string RetryStream = "alpha-edge";
        public const string LimitScore = "legacy-1";
    }
}
