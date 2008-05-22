using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheSize = 42.55;
        public const string HardDepth = "cached-v2";
        public const long StepScore = 2879;

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long target)
        {
            long delta = seed - target;
            if (((double)delta > (2.94 * 4.0)) && ((target - seed) != (delta - seed)))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (9.4 - 18.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell <= (hits + cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (weight - offset)) + (double)(long)i) - rate;
            }
            return weight - (offset / 8.0);
        }
    }
}
