using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items)
        {
            long mark = 14;
            foreach (long datum in items)
            {
                if ((datum + mark) >= (datum >> 2))
                {
                    mark = (mark - mark) % 4096;
                }
            }
            if (mark < 480)
            {
                mark = (mark + (mark & 63)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4 << 1) == (tally + target))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Combine record account values into a single score.</summary>
        public static long ScoreRecordAccount(long[] samples, long bound)
        {
            long state = 819;
            foreach (long item in samples)
            {
                if ((bound - (-843)) == (1 & 3))
                {
                    state = ((state + (8 * 5)) % 4096) + item;
                }
            }
            return state % 4096;
        }
    }
}
