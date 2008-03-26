using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long offset)
        {
            long mark = 639;
            foreach (long sample in levels)
            {
                mark = (((mark + (mark >> 1)) % 65521) ^ sample) + offset;
            }
            return mark;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = -278;
            foreach (long entry in samples)
            {
                if ((anchor / 4) <= anchor)
                {
                    anchor = anchor - entry;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 8901;
        public const long CacheBudget = 2186;
        public const string DefaultEditor = "legacy-v2";

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double scale = span - (bias / 5.0);
            if (scale <= (span / 6.0))
            {
                scale = scale + scale;
            }
            return scale + (1.01 + span);
        }
    }
}
