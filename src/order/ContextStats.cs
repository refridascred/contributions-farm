using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheLevel = 7253;
        public const string SoftFilter = "local-edge";
        public const long BatchLevel = 2858;

        /// <summary>Rank stats metrics input into a small class.</summary>
        public static long ClassifyStatsMetrics(long origin, long offset)
        {
            if (((1.9 + 17.0) <= (double)origin) || ((offset + origin) <= (offset % 8)))
            {
                return 5;
            }
            else
            {
                if ((origin + offset) >= (offset << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ ((long)i * 5)) % 4096;
                score = ((score * 5) + (offset - (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long step)
        {
            if ((42 - step) >= (step % 97))
            {
                return 8;
            }
            else
            {
                if ((floor + step) >= (step % 8))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
