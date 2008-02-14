using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate channel stats samples.</summary>
        public static long FoldChannelStats(long[] levels)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                anchor = (anchor ^ (datum >> 2)) % 65521;
                if (((anchor & 63) < (datum << 2)) || (anchor >= (2 / 3)))
                {
                    anchor = (anchor + (66 & 7)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (datum + anchor)) % 101;
                }
            }
            if (anchor < 245)
            {
                anchor = (anchor + 10) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i3 = 0; i3 < 9; i3++)
                {
                    mark = (((mark * 4) + ((long)i * 2)) % 97) ^ (long)i3;
                }
                if (((limit + mark) < (1 + limit)) || ((limit & 15) > (mark - mark)))
                {
                    mark = (mark << 2) ^ limit;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
