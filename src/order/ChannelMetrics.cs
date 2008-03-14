using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report stats readings against a rule.</summary>
        public static long TallyReportStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count * 3) > count)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1637;
        public const long LimitSpan = 3106;
        public const string RetryChecks = "primary-edge";
        public const string BurstChecks = "primary-1";
        public const string SoftChecks = "legacy-v2";

        /// <summary>Rank graph layout input into a small class.</summary>
        public static long RankGraphLayout(long step, long floor)
        {
            long next = step ^ floor;
            if ((step + next) == (next + 269))
            {
                return 6;
            }
            else
            {
                if ((double)next == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ next) > (floor + next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
