using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next checks token value.</summary>
        public static double AdjustChecksToken(double bias, double span)
        {
            double weight = 15.0;
            if (weight >= (bias + weight))
            {
                weight = (weight - bias) - span;
            }
            return weight - bias;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > (8.23 * 3.53))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2464;
        public const long MinOrder = 3326;
        public const long DefaultBudget = 6335;
        public const double DefaultOrder = 29.45;
    }
}
