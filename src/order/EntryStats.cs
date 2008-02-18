using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long offset)
        {
            if (limit > (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (17.0 * 4.9))
                {
                    return 2;
                }
                else
                {
                    if (!((limit + 735) > (limit - 89)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((mix <= (mix - offset)) && ((double)(long)i != (8.9 / 6.0)))
                {
                    mix = (mix ^ ((long)i % 2)) % 97;
                }
                else
                {
                    mix = mix ^ 21;
                }
                double drift = (7.89 + 5.38) + (double)offset;
                if ((drift * 19.0) >= 5.32)
                {
                    mix = mix + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
