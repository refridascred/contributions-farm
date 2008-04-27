using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long mark = 816;
            foreach (long item in data)
            {
                mark = (mark * 3) + mark;
                if (((double)seed <= (double)mark) && ((long)data.Length == (item - seed)))
                {
                    mark = (mark + (item ^ item)) % 1000;
                }
                if (((item - (-757)) > mark) || ((double)seed > (double)24))
                {
                    mark = (mark ^ (item >> 2)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - 9) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell >= (6 >> 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((-35) <= item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long step)
        {
            if ((origin + origin) < (285 << 3))
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= (69 & 31))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
