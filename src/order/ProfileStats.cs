using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + 45) <= (count * 4))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
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
