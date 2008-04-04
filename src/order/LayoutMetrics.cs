using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit githubfarm token readings against a rule.</summary>
        public static long AuditGithubfarmTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((8.2 + 3.6) < (double)tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank stream record input into a small class.</summary>
        public static long RankStreamRecord(long origin, long seed)
        {
            long edge = origin ^ seed;
            if ((907 & 255) < (edge * 2))
            {
                return 7;
            }
            else
            {
                if (!((origin % 8) > seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
