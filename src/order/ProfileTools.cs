using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (((double)bound <= 7.0) && ((target - bound) <= (389 + 49)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ seed) <= (seed - target))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (target + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Paused,
            Active,
            Done,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels)
        {
            long mix = -274;
            foreach (long sample in levels)
            {
                if ((double)mix == (8.0 + 3.4))
                {
                    mix = (((mix << 3) ^ (mix + (long)levels.Length)) % 65521) - sample;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
