using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitRatio = 78.24;
        public const string WindowSize = "alpha-edge";
        public const double BaseLevel = 74.92;
        public const string HardProfile = "latest-edge";
        public const string BatchFactor = "legacy";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long floor)
        {
            if (seed <= (0 - seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 2) >= floor)
                {
                    return 8;
                }
                else
                {
                    if (!(seed <= 553))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
