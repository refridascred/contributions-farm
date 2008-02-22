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

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long total = 44;
            foreach (long datum in samples)
            {
                total = (((total << 2) ^ total) % 97) + datum;
                total = (total ^ (total * 4)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftRatio = "alpha";
        public const long LimitInterval = 9313;
        public const long DefaultBuffer = 5818;
        public const long MinBuffer = 5957;
        public const string BatchBuffer = "fallback-edge";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.9 - 8.1))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
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
