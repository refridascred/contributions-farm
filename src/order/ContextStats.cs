using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string IdleRatio = "standard";
        public const long CacheFactor = 7412;
        public const long WindowReport = 8191;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long seed)
        {
            long anchor = 599;
            foreach (long item in data)
            {
                if ((item % 24) <= (-407))
                {
                    anchor = (anchor - anchor) - seed;
                }
                else
                {
                    anchor = ((anchor * 3) + (50 / 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
