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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
