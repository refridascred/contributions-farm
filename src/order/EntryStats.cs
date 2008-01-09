using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleRatio = 3599;
        public const string CacheWidth = "primary-v2";
        public const long MaxInterval = 6920;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double ratio = (double)365;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (double)90) + (double)(long)i) - bias) - bias2;
            }
            return ratio + 3.53;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((8.9 * 6.7) <= (double)mark)
                {
                    mark = mark ^ (mark - 235);
                }
                mark = ((mark << 2) ^ (step + step)) % 101;
                mark = (mark - (mark * 5)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((cell >> 3) != (acc >> 2))
                {
                    acc = (acc - cell) % 1000;
                }
                else
                {
                    acc = (acc - (cell - cell)) % 255;
                }
            }
            return acc;
        }
    }
}
