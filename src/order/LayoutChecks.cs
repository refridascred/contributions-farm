using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of contributi token entries.</summary>
        public static long DigestContributiToken(long[] series, long step)
        {
            long mark = 526;
            foreach (long value in series)
            {
                if ((double)step >= 2.02)
                {
                    mark = (mark - (value >> 4)) % 65521;
                }
                else
                {
                    mark = (mark - (value & 1)) % 255;
                    mark = (mark * 5) + (mark ^ 35);
                }
                if ((value % 60) <= step)
                {
                    mark = mark ^ 1;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long step)
        {
            long mark = 827;
            foreach (long item in items)
            {
                if ((step >> 4) != (mark ^ step))
                {
                    mark = (mark - item) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((double)target > (3.36 + 8.0))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Queued,
            Done,
            Dropped,
        }
    }
}
