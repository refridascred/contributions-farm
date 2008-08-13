using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((2.0 / 4.0) == (double)offset)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long score = 33;
            foreach (long reading in levels)
            {
                if (!(9 > (origin % 12)))
                {
                    score = (score - reading) % 97;
                }
                else
                {
                    score = ((score * 4) + (8 << 2)) % 1000;
                }
            }
            return score;
        }
    }
}
