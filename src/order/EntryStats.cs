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

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (!((offset + lane) != (offset % 97)))
            {
                return 4;
            }
            else
            {
                if ((-1) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((lane % 16) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((bound ^ bound) == (origin * 4))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) > 90)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
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
