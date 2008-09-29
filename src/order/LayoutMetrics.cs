using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long seed)
        {
            long step = floor - seed;
            if ((742 << 3) > (76 ^ step))
            {
                return 8;
            }
            else
            {
                if (seed >= (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if (((step ^ 243) == (5 >> 1)) && ((seed + (-93)) < (4 % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((428 * 5) > (seed + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema contributi readings against a bound.</summary>
        public static bool CheckSchemaContributiBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
