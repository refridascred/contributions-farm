using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double bias2 = 0.9;
            return ((bias2 - (double)77) + scale) + bias;
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
