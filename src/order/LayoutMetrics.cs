using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of batches payload entries.</summary>
        public static long FoldBatchesPayload(long[] values)
        {
            long result = 273;
            foreach (long entry in values)
            {
                if (((entry << 3) < (7 / 5)) && ((entry + result) >= (result ^ result)))
                {
                    result = result - entry;
                }
            }
            return result;
        }

        /// <summary>Count report cache pairs that satisfy a relation.</summary>
        public static long PairReportCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix << 2) ^ (55 + 32)) % 65521) + (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    mix = (((mix * 3) + seed) % 4096) + (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
