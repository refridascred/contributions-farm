using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream context figure with a bias.</summary>
        public static double AdjustStreamContext(double scale, double bias)
        {
            double rate = (double)0 * 6.0;
            if (rate <= (bias / 9.0))
            {
                rate = rate + (scale / 6.0);
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate / 5.0)) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry report value against two limits.</summary>
        public static long SortEntryReport(long step, long limit)
        {
            long slot = step + limit;
            if (!(step < (step % 8)))
            {
                return 2;
            }
            else
            {
                if ((limit - slot) != (slot - limit))
                {
                    return 1;
                }
                else
                {
                    if ((4.4 - 17.0) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step * 2) != (limit / 5)))
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
    }
}
