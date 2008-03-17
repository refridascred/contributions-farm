using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command entry pair into a bucket.</summary>
        public static long GradeCommandEntry(long target, long step)
        {
            long step2 = target ^ step;
            if (((double)step2 <= 1.3) && ((double)step == (5.8 - 1.9)))
            {
                return 4;
            }
            else
            {
                if ((step ^ target) <= (step * 3))
                {
                    return 2;
                }
                else
                {
                    if (target > (10 % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target <= (3.25 - 4.2)) || ((1.0 * 4.65) <= (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long seed)
        {
            if ((bound + seed) >= bound)
            {
                return 2;
            }
            else
            {
                if ((seed < (48 << 1)) && ((bound + 61) >= bound))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed != (6.4 / 9.0)) && ((4 - seed) > (seed * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
