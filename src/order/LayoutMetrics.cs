using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream githubfarm values into a single score.</summary>
        public static long TotalStreamGithubfarm(long[] levels)
        {
            long mix = -87;
            foreach (long reading in levels)
            {
                if ((reading >> 5) == (reading >> 3))
                {
                    mix = (mix << 3) ^ 79;
                }
                if (((double)mix <= (double)771) && ((reading * 2) >= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long step)
        {
            long next = target - step;
            if ((target & 127) != (step - target))
            {
                return 8;
            }
            else
            {
                if ((target / 4) <= (target - next))
                {
                    return 3;
                }
                else
                {
                    if (next < (next / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
