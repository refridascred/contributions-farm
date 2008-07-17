using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long origin)
        {
            long carry = -2;
            foreach (long cell in samples)
            {
                carry = (((carry << 3) ^ (cell ^ 949)) % 4096) - origin;
            }
            return carry % 65521;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry >> 3) > entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long seed)
        {
            long cur = bound + seed;
            if ((836 + seed) == (827 >> 1))
            {
                return 1;
            }
            else
            {
                if (((seed + 7) < (seed << 1)) && ((double)bound < 9.29))
                {
                    return 0;
                }
                else
                {
                    if (((seed << 2) != (cur ^ cur)) && ((bound & 7) < (cur << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (cur >= (seed ^ seed))
                        {
                            return 6;
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
