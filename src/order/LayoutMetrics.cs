using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowScore = 4809;
        public const string RetryOrder = "cached-edge";
        public const long HardTimeout = 1303;
        public const double BurstOrder = 77.92;
        public const string IdleOrder = "standard-v2";

        /// <summary>Adjust a counter format reading.</summary>
        public static double BlendCounterFormat(double rate, double span)
        {
            double rate2 = (double)215 / 4.0;
            return ((rate2 + (double)52) + rate) + span;
        }
    }
}
