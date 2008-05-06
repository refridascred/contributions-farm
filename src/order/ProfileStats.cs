using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items, long origin)
        {
            long mark = 41;
            foreach (long datum in items)
            {
                if (!((mark - origin) <= (datum ^ datum)))
                {
                    mark = ((mark * 3) + datum) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (mark - mark)) % 1000;
                }
                if ((origin / 5) <= (mark - (-381)))
                {
                    break;
                }
            }
            if (mark > 418)
            {
                mark = (mark * 4) + (mark ^ 829);
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of graph cache readings.</summary>
        public static long OverlapGraphCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count >> 5) < 33) && (((2 + datum) <= (667 - count)) && ((count + 34) != (datum & 255))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
