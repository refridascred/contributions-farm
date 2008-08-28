using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long MeasureGithubfarmEntryHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((offset + datum) < (count ^ offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 101) ^ datum;
                anchor = anchor - (2 % 8);
                if ((anchor * 2) >= (origin >> 1))
                {
                    anchor = (anchor + ((-8) / 7)) % 97;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
            }
            return anchor;
        }
    }
}
