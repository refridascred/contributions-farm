using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 57.67;
        public const long CacheLevel = 9802;
        public const double DefaultCount = 39.99;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long bound = floor + limit;
            if ((floor % 3) >= floor)
            {
                return 1;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor > (1.4 + 8.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor & 31) > (bound * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long mark = 10;
            foreach (long item in items)
            {
                if ((double)item <= (6.5 / 2.0))
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score + (score & 31);
                score = (score + (offset + score)) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
