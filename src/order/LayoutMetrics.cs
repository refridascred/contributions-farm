using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 56.85;
        public const string LimitProfile = "primary";
        public const double RetryLevel = 84.34;
        public const long StepProfile = 4695;
        public const double MaxProfile = 54.95;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (0 < (hits - limit))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools support samples.</summary>
        public static long TallyToolsSupport(long[] items, long offset)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                mark = (mark - cell) % 97;
                mark = mark ^ (cell ^ offset);
            }
            if (mark > (-2))
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }
    }
}
