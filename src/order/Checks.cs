using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long bound)
        {
            if (bound > (4 % 3))
            {
                return 4;
            }
            else
            {
                if ((bound % 64) >= (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 82) <= bound) && (((-52) - origin) > (bound - (-3))))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample / 4) >= 300)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((4 * 3) == (step << 3))
            {
                return 7;
            }
            else
            {
                if ((double)limit == (1.4 - 5.74))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
