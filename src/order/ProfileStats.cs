using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long floor, long offset)
        {
            if ((floor ^ floor) >= (2 % 10))
            {
                return 3;
            }
            else
            {
                if (!((offset / 8) != (812 ^ floor)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor + floor) != (340 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up tools entry samples.</summary>
        public static long CompareToolsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((6.4 * 20.0) != (double)seed))
                {
                    anchor = (anchor ^ (532 / 8)) % 101;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor - seed) % 65521;
                    anchor = (anchor - ((long)i2 - seed)) % 1000;
                }
                if (((anchor & 31) <= (seed ^ seed)) && ((anchor / 3) > (anchor + anchor)))
                {
                    anchor = (anchor - (anchor / 4)) % 97;
                }
                else
                {
                    anchor = (anchor - (anchor + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
