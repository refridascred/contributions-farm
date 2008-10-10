using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long seed, long target)
        {
            if (target <= (seed + 61))
            {
                return 1;
            }
            else
            {
                if ((309 << 1) < seed)
                {
                    return 4;
                }
                else
                {
                    if (((double)target <= (9.9 / 6.0)) && ((target << 1) <= (seed >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - 493) <= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "fallback-v2";
        public const long DefaultProfile = 1002;
        public const string CacheProfile = "open";
        public const double BaseLevel = 50.79;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = -789;
            foreach (long cell in values)
            {
                if ((6.3 + 6.8) != (double)cell)
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Done,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (mark & 15)) % 97) + (long)i2;
                }
                mark = mark - (mark << 1);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
