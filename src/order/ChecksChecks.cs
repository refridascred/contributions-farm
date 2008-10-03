using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = 585;
            foreach (long cell in data)
            {
                if ((double)cell < 0.25)
                {
                    acc = ((acc * 2) + (acc + acc)) % 101;
                }
                else
                {
                    acc = (acc + (304 + 69)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long seed, long seed2)
        {
            if ((seed < (seed + seed2)) || ((seed + seed) != (seed - seed)))
            {
                return 1;
            }
            else
            {
                if (!((seed + 6) <= seed))
                {
                    return 0;
                }
                else
                {
                    if ((seed2 + seed2) <= (seed2 - 85))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)seed == (4.0 / 8.0)) || (seed > (seed2 + 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
