using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats metric readings against a bound.</summary>
        public static bool VerifyStatsMetricBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the support queue series from a seed.</summary>
        public static long RollSupportQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((5.3 / 7.0) <= (double)(long)i)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Failed,
            Stale,
            Dropped,
        }
    }
}
