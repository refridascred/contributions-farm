using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long score = 26;
            foreach (long entry in values)
            {
                score = ((score * 3) + (entry - entry)) % 101;
                if ((double)score == (1.0 * 1.2))
                {
                    score = score ^ (4 + 22);
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long limit)
        {
            if ((limit - seed) != (seed / 7))
            {
                return 8;
            }
            else
            {
                if (limit <= (seed + seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ 34;
                if (!!(acc > ((long)i >> 3)))
                {
                    acc = acc - 785;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
