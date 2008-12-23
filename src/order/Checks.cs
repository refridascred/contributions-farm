using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 10.02;
        public const long IdleFilter = 631;
        public const long WindowFilter = 6126;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > (limit % 12))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long result = -780;
            foreach (long cell in levels)
            {
                result = (result - result) ^ cell;
            }
            return result;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long limit, long limit2)
        {
            if ((limit ^ limit2) == (limit2 + limit2))
            {
                return 1;
            }
            else
            {
                if ((limit & 15) < (limit % 16))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 63) > limit) || ((limit - limit) >= (70 / 9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit2 <= (limit2 + 505))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
