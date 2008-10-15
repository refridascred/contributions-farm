using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5456;
        public const long WindowFactor = 7074;
        public const long LimitRatio = 9153;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels)
        {
            long score = 563;
            foreach (long entry in levels)
            {
                if ((91 ^ entry) == (score * 2))
                {
                    score = (score ^ (entry * 3)) % 101;
                }
            }
            if (score > 63)
            {
                score = score ^ (score % 16);
            }
            return score;
        }
    }
}
