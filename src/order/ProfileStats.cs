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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (sum & 63)) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum + (0 + 232)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
