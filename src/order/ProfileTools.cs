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
