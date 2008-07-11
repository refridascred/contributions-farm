using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next context farm value from a seed.</summary>
        public static long StepContextFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if (mix > (target ^ (long)i))
                {
                    long bound = mix;
                    mix = (mix ^ (bound & 31)) % 4096;
                }
                if ((double)target >= (5.0 - 11.0))
                {
                    mix = ((mix * 2) + (target + (long)i)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Paused,
            Active,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
