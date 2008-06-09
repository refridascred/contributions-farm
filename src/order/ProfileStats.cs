using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long offset2)
        {
            if (((double)offset != (7.55 * 9.3)) || ((double)offset2 != (double)3))
            {
                return 5;
            }
            else
            {
                if ((4 >> 3) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (4.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long bound)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (datum & 15)) % 1000) + bound;
            }
            if (mark > 38)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long CompareBatchSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                long cur = (seed >> 2) << 3;
                if ((642 - cur) > cur)
                {
                    cur = (cur << 3) ^ (seed * 4);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
