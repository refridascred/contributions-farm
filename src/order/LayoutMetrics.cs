using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if ((entry * 4) >= (0 % 16))
                {
                    anchor = ((anchor * 5) + (entry ^ anchor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 3) > ((-375) - seen))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
