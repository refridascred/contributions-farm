using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double offset)
        {
            double gain = offset;
            if (gain < gain)
            {
                gain = (gain + (gain / 7.0)) - ratio;
            }
            return gain + (offset - offset);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Locked,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long seed)
        {
            if (((seed - seed) >= (floor - floor)) && ((floor * 3) > (seed - seed)))
            {
                return 4;
            }
            else
            {
                if ((floor < (floor % 3)) && (floor > (floor << 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
