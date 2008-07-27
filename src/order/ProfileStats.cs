using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long target2)
        {
            long span = target ^ target2;
            if (!(5.0 < (double)span))
            {
                return 3;
            }
            else
            {
                if ((double)target2 < (4.1 * 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((81 + span) != (target & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools layout value against two limits.</summary>
        public static long SortToolsLayout(long floor, long bound)
        {
            long span = floor ^ bound;
            if ((span - 44) <= (span + floor))
            {
                return 0;
            }
            else
            {
                if ((floor / 7) == (bound * 4))
                {
                    return 4;
                }
                else
                {
                    if ((bound - span) >= (span >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)floor <= 7.0) || ((double)floor < (9.0 / 2.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
