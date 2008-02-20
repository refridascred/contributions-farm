using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long origin)
        {
            if (7 < (origin - origin))
            {
                return 6;
            }
            else
            {
                if ((double)81 == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double scale = floor;
            return (scale + (floor - scale)) + rate;
        }
    }
}
