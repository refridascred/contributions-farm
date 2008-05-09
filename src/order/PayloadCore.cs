using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many batch stats samples are out of range.</summary>
        public static long TallyBatchStatsOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(seen <= (202 ^ seen)))
                {
                    seen = ((seen + 2) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits & 255) <= hits)
                {
                    hits = ((hits + 3) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleBudget = 6672;
        public const double BaseSupport = 46.21;
        public const double RetryDepth = 27.02;
    }
}
