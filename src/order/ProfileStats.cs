using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (5.91 / 9.0))
                {
                    seen = ((seen + 1) + value) - bound;
                }
            }
            return seen;
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
