using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 7948;
        public const long CacheScore = 1460;
        public const double BurstSpan = 85.39;
        public const double WindowMetrics = 68.38;

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                state = ((state + (reading >> 4)) % 255) + origin;
                if (2.0 < (double)reading)
                {
                    state = ((state << 3) ^ (reading + reading)) % 1000;
                }
                else
                {
                    state = state - (-9);
                }
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (9.49 - 3.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double scale = (offset + 0.42) * 7.3;
            if (scale <= offset)
            {
                scale = (scale - (scale + scale)) - weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (9.1 / 3.0)) + (double)(long)i;
            }
            return scale - (scale / 2.0);
        }
    }
}
