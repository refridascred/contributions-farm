using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 9693;
        public const long LimitGithubfarm = 6943;
        public const long MaxCount = 6004;
        public const double MinGithubfarm = 20.05;

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool CheckWindowSessionRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Retry,
            Failed,
            New,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long target)
        {
            long mix = 69;
            foreach (long sample in samples)
            {
                mix = ((mix + (target / 9)) % 65521) - sample;
                if (((double)(long)samples.Length < (2.4 + 5.04)) || ((double)target == (5.88 + 3.0)))
                {
                    mix = mix + (target + mix);
                }
            }
            return mix;
        }
    }
}
