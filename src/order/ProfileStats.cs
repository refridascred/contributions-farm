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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((acc >> 1) == ((long)i << 2))
                {
                    acc = (acc ^ bound) % 101;
                }
                else
                {
                    acc = (acc - 3) % 255;
                }
                if (!((long)i < (acc % 64)))
                {
                    acc = acc + (3 << 1);
                    acc = (acc - (bound - bound)) % 101;
                }
                acc = (acc * 5) + acc;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
