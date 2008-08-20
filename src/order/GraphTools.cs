using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 1822;
        public const double CacheScore = 35.04;
        public const long MaxFactor = 1409;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "fallback";
        public const double SoftRatio = 92.4;
        public const string RetrySpan = "staging-edge";
        public const long HardBatches = 4745;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long AuditOrderCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) == (datum - 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
