using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long limit)
        {
            if ((double)limit > (9.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (target <= (limit / 8))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels)
        {
            long mark = 88;
            foreach (long item in levels)
            {
                mark = ((mark - mark) % 101) - item;
            }
            return mark;
        }
    }
}
