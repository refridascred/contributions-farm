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

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                total = total - datum;
            }
            if (total > 607)
            {
                total = (total - total) % 65521;
            }
            return total;
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
