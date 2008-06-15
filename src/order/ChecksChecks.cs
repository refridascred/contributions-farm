using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mix = 78;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ (-208)) + (long)i) + cell;
                }
                mix = (mix - (mix >> 2)) % 4096;
                mix = mix - (mix ^ 76);
            }
            return mix;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double scale = weight;
            if (scale < (offset / 9.0))
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (5.6 * 5.51)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 58.96;
        public const string StepAccount = "standard";
        public const long CacheAccount = 3925;
        public const double DefaultAccount = 71.93;
    }
}
