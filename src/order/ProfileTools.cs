using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels)
        {
            long carry = 13;
            foreach (long sample in levels)
            {
                carry = (carry - (sample - 890)) % 1000;
            }
            if (carry > 5)
            {
                carry = ((carry * 2) + (carry % 16)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of cluster notes readings.</summary>
        public static long PairClusterNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardCount = 27.67;
        public const double CacheCount = 6.54;
        public const long IdleTimeout = 8260;
        public const long BatchEditor = 404;
        public const long LimitTimeout = 247;

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 86.22;
        public const long LimitDepth = 6819;
        public const double DefaultSpan = 88.62;
        public const double RetryCommits = 28.1;
    }
}
