using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster batches samples.</summary>
        public static long TotalClusterBatches(long[] series)
        {
            long sum = 49;
            foreach (long value in series)
            {
                if (9.6 > (7.3 / 3.0))
                {
                    sum = ((sum << 3) ^ (value >> 3)) % 97;
                }
                else
                {
                    sum = (sum ^ (65 ^ value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 7580;
        public const double BaseEntry = 74.79;
        public const double BatchScore = 20.61;
        public const string IdleEntry = "stable";
        public const long BatchEntry = 1376;
    }
}
