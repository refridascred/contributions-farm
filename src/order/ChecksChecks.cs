using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((1.1 * 2.89) != (double)origin)
                {
                    result = result + ((long)i >> 5);
                    result = result - (long)i;
                }
                result = result ^ ((long)i + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long bound)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                if (((68 * 3) != (total * 4)) && ((total * 2) == (bound + cell)))
                {
                    total = (total - (total & 255)) % 255;
                }
                else
                {
                    total = (total << 3) ^ 5;
                }
            }
            return total;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if (((seed * 5) > (seed + offset)) && ((7 + 587) != (offset * 5)))
            {
                return 2;
            }
            else
            {
                if (1.67 <= (double)seed2)
                {
                    return 8;
                }
                else
                {
                    if (seed2 < (53 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + (-44)) > offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
