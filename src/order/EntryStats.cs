using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long CountGraphSchemaGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)item > 2.9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of order stats entries.</summary>
        public static long TallyOrderStats(long[] levels, long step)
        {
            long mark = 847;
            foreach (long reading in levels)
            {
                mark = ((((mark << 2) ^ (38 >> 1)) % 4096) - reading) + step;
            }
            if (mark < 45)
            {
                mark = (mark - (mark + mark)) % 101;
            }
            return mark;
        }
    }
}
