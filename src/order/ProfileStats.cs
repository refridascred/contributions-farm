using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long bound)
        {
            long slot = offset - bound;
            if ((slot << 1) < (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((bound + 488) >= (offset >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((5 + offset) >= (4 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.8 + 4.27) != (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long sum = 871;
            foreach (long cell in series)
            {
                if ((double)sum != (5.0 * 0.41))
                {
                    sum = (sum * 3) + (cell * 3);
                }
            }
            if (sum > 5)
            {
                sum = (sum + (bound % 24)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) + (double)(long)i) + floor;
            }
            return load - ratio;
        }
    }
}
