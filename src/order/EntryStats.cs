using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = 87;
            foreach (long cell in series)
            {
                if ((cell + 743) <= cell)
                {
                    mark = mark ^ (cell + cell);
                }
            }
            return mark;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            New,
            Queued,
            Active,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
