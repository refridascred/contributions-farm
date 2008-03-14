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

        /// <summary>Project the next account commits value.</summary>
        public static double AdjustAccountCommits(double gain, double span)
        {
            double gain2 = (double)((-63) - 989);
            return (gain2 - (gain + 8.16)) + span;
        }
    }
}
