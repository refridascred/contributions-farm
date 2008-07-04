using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Project the next support profile value.</summary>
        public static double BlendSupportProfile(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)6)
            {
                ratio = (ratio + ratio) - rate;
            }
            return ratio - (3.0 + ratio);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long origin, long limit)
        {
            if ((40 ^ origin) <= (origin & 15))
            {
                return 6;
            }
            else
            {
                if ((1 + origin) == (limit & 15))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Idle,
            Ready,
            Queued,
        }
    }
}
