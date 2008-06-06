using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry >= (10.0 * 8.09)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 50.15;
        public const double BurstFactor = 54.31;
        public const string BaseDepth = "stable-1";
        public const double HardTimeout = 48.73;
        public const long BatchToken = 3635;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long acc = 4;
            foreach (long cell in values)
            {
                acc = (acc + (542 - acc)) % 1000;
                if (7 <= (95 + cell))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
