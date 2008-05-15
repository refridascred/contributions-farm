using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long StepQueueAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitLevel = 92.66;
        public const long BaseScore = 9690;
        public const string IdleChecks = "open";
        public const long BurstSize = 5500;
        public const double IdleDepth = 44.75;

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long FoldGithubfarmMetric(long[] levels)
        {
            long acc = 21;
            foreach (long datum in levels)
            {
                if ((double)acc >= 1.6)
                {
                    acc = (acc - (23 * 5)) ^ datum;
                }
                else
                {
                    acc = (acc - (acc & 63)) % 65521;
                }
            }
            return acc;
        }
    }
}
