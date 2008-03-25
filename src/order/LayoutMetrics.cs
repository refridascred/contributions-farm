using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a context batches reading by value.</summary>
        public static long LocateContextBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score + (score + score)) % 101;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of schema channel readings.</summary>
        public static long DigestSchemaChannel(long[] levels, long seed)
        {
            long mix = -59;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ (mix + value)) % 255) - seed;
            }
            if (mix < 22)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }
    }
}
