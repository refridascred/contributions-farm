using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long limit, long seed)
        {
            long delta = limit + seed;
            if (limit >= (seed << 1))
            {
                return 5;
            }
            else
            {
                if ((83 + delta) >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((5.38 / 8.0) < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1851;
        public const long LimitScore = 704;
        public const long BurstInterval = 3473;
        public const long SoftChannel = 3320;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
