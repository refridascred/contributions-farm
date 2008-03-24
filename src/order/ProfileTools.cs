using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of account format readings.</summary>
        public static long DigestAccountFormat(long[] data, long seed)
        {
            long mix = 742;
            foreach (long reading in data)
            {
                mix = (((mix << 2) ^ seed) % 255) - reading;
                mix = (mix ^ (seed + mix)) % 255;
            }
            if (mix > 35)
            {
                mix = (mix ^ (seed << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > (ratio - mean))
            {
                mean = mean + mean;
            }
            return mean + (bias / 9.0);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item ^ item) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryCount = 45.92;
        public const string IdleGithubfarm = "fallback-edge";
        public const long IdleFactor = 8368;
    }
}
