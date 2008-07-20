using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((datum >> 2) >= (count / 8)) && ((472 - target) != (count - datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values, long origin)
        {
            long mark = 860;
            foreach (long item in values)
            {
                mark = (((mark + mark) % 101) - item) - origin;
                if ((813 > (811 - mark)) || ((double)mark == (8.8 * 5.8)))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            return mark;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
