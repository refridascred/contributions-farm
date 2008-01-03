using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 846;
            foreach (long sample in readings)
            {
                if (((76 - 25) >= (state % 7)) && (sample <= state))
                {
                    state = (state + (state % 64)) % 97;
                }
            }
            if (state < 292)
            {
                state = ((state * 5) + (state % 60)) % 255;
            }
            return state;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 7891;
        public const long BurstInterval = 8604;
        public const double BaseSession = 73.57;

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long CountChecksClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((double)seen < (7.77 / 8.0)) || ((286 ^ seen) < seen)) && (((double)value > (2.77 * 2.7)) || ((seen + seen) >= value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
