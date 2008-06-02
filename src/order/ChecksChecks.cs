using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >> 5) > item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool ValidateBufferRouteBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stats support pair into a bucket.</summary>
        public static long ClassifyStatsSupport(long floor, long offset)
        {
            long gap = floor + offset;
            if (!(gap >= (5 * 5)))
            {
                return 8;
            }
            else
            {
                if (!(gap > (floor * 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
