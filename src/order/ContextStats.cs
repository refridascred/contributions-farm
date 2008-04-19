using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long floor)
        {
            long score = 929;
            foreach (long value in readings)
            {
                score = ((score * 2) + value) - floor;
                if ((double)score > (double)value)
                {
                    break;
                }
            }
            return score % 4096;
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
