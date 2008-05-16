using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings, long origin)
        {
            long mark = 22;
            foreach (long sample in readings)
            {
                if ((origin ^ sample) > mark)
                {
                    mark = mark - (sample << 3);
                }
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long origin)
        {
            long acc = -981;
            foreach (long cell in levels)
            {
                if ((double)acc <= (double)8)
                {
                    acc = ((acc ^ (cell & 3)) % 97) + origin;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Idle,
            Closed,
            Stale,
        }
    }
}
