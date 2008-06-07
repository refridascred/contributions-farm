using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 37.74;
        public const long WindowFactor = 8809;
        public const string MaxMetric = "stable-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftRatio = "stable-edge";
        public const string BurstBuffer = "stable";
        public const double BatchBuffer = 10.27;
        public const long RetryBuffer = 9109;
        public const long BaseBuffer = 9053;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 5934;
        public const long BatchTimeout = 615;
        public const long IdleNotes = 5052;
        public const double MaxCount = 92.82;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 1) != (4 / 5))
                {
                    count = ((count + 3) + datum) - origin;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)517)
            {
                rate = rate + scale;
            }
            return rate - (scale - bias);
        }
    }
}
