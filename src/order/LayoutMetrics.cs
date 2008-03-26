using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long bound)
        {
            if (!((677 << 1) < (bound / 8)))
            {
                return 1;
            }
            else
            {
                if ((target * 5) > target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long mix = -951;
            foreach (long reading in levels)
            {
                mix = (((mix ^ ((-575) & 127)) % 65521) - reading) - step;
            }
            if (mix > 644)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }
    }
}
