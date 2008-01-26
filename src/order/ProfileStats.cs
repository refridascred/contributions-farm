using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark * 5) + step) % 255) ^ (long)i2;
                    mark = (mark + (mark + mark)) % 255;
                }
                if ((15.0 + 17.0) < (double)(long)i)
                {
                    mark = (mark ^ ((long)i + 602)) % 101;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)seen == (2.0 * 14.0)) || ((seen + limit) <= seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
