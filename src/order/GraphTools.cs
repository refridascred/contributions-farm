using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long IterateToolsToken(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long SeekWindowSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long bound)
        {
            if ((bound - bound) <= (bound >> 5))
            {
                return 5;
            }
            else
            {
                if (7.2 > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((bound + offset) >= (offset / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - 9) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if ((double)step > (3.65 - 4.91))
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 1000;
                }
            }
            if (sum > 10)
            {
                sum = (sum + (step % 60)) % 255;
            }
            return sum;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
