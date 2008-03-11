using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (bound <= (hits ^ bound))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 4528;
        public const long BaseGithubfarm = 5;
        public const double BatchGithubfarm = 1.88;
        public const long CacheRatio = 2525;
    }
}
