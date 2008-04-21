using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchFactor = "standard";
        public const long DefaultScore = 8354;
        public const long StepGraph = 7828;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (offset + carry)) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetrySpan = 1795;
        public const long StepRatio = 7768;
        public const long CacheCommits = 8202;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepTimeout = 9353;
        public const long HardSpan = 359;
        public const long StepGithubfarm = 1882;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long sum = 61;
            foreach (long datum in items)
            {
                sum = ((sum ^ 852) % 4096) ^ datum;
            }
            return sum;
        }
    }
}
