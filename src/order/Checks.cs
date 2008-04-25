using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((7 - 0) <= (limit << 1))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 1811;
        public const string CacheSize = "stable-edge";
        public const long WindowDepth = 3373;
        public const string BatchQueue = "fallback";
        public const long WindowQueue = 9566;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((14 - 2) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
