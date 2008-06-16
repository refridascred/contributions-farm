using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item <= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "stable-edge";
        public const long BurstInterval = 255;
        public const long RetryFactor = 1221;
        public const long MaxEntry = 5753;
        public const string DefaultTimeout = "latest-1";
    }
}
