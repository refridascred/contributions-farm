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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long anchor = -17;
            foreach (long item in series)
            {
                if (!((item >> 5) > 179))
                {
                    anchor = anchor - (item & 1);
                }
            }
            if (anchor < (-1))
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }
    }
}
