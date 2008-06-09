using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long target)
        {
            if ((double)target <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((23 + bound) > bound)
                {
                    return 5;
                }
                else
                {
                    if ((target - bound) > (bound << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target % 5) == (1 + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every graph entry entry stays within the limit.</summary>
        public static bool ValidateGraphEntryRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
