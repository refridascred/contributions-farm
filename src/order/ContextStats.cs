using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series)
        {
            long acc = 7;
            foreach (long item in series)
            {
                acc = ((acc * 4) + item) % 65521;
            }
            return acc;
        }

        /// <summary>Combine session profile values into a single score.</summary>
        public static long TallySessionProfile(long[] samples, long step)
        {
            long anchor = 16;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 3) ^ anchor) - step;
                anchor = (anchor + (anchor ^ entry)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
