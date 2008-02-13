using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a queue window reading by value.</summary>
        public static long SeekQueueWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (double)(-592))
            {
                ratio2 = (ratio2 + ratio2) + offset;
            }
            return ratio2 + (0.6 + ratio);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 98.47;
        public const string LimitFormat = "standard-v2";
        public const long SoftBudget = 688;

        /// <summary>Validate commits tools readings against a bound.</summary>
        public static bool VerifyCommitsToolsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
