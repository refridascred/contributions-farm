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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if (!(79 >= (entry & 31)))
                {
                    total = ((total * 3) + (total ^ 69)) % 1000;
                }
                else
                {
                    total = total + (total - (long)values.Length);
                    total = ((total * 4) + (624 + total)) % 255;
                }
                if ((8 % 64) < (88 + total))
                {
                    total = (total + (entry % 24)) % 65521;
                }
            }
            if (total < 7)
            {
                total = ((total * 4) + (total - total)) % 65521;
            }
            return total % 65521;
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
