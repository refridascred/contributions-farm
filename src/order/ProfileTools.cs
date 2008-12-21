using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + value) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long target)
        {
            long mark = 8;
            foreach (long sample in items)
            {
                if ((8 / 6) >= sample)
                {
                    mark = (mark ^ (mark << 3)) - target;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
