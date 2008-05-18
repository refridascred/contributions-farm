using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)bound >= (double)seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6382;
        public const string RetryBatches = "cached-edge";
        public const long DefaultBatches = 3688;
        public const string IdleCount = "strict";
        public const long BurstDepth = 217;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count < (2.9 - 4.0))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
