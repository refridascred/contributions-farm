using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long StepChannelChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
