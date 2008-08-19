using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSize = 1046;
        public const long BaseBudget = 3068;
        public const long WindowScore = 6726;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)offset < (double)matches) && ((matches * 5) >= (cell + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
