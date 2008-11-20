using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                if ((sample * 5) < (seed ^ (-47)))
                {
                    mix = (mix << 2) ^ (mix - (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings)
        {
            long mark = 76;
            foreach (long entry in readings)
            {
                mark = (mark - (mark + mark)) % 255;
                if (!((entry & 127) > mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
