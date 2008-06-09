using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseBudget = "alpha-v2";
        public const long BaseMetrics = 8126;
        public const long DefaultMetrics = 6774;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long score = -60;
            foreach (long datum in items)
            {
                if ((score + 2) < (datum - datum))
                {
                    score = ((score << 2) ^ (score % 10)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8005;
        public const long CacheToken = 1786;
        public const long StepToken = 5385;
        public const long DefaultToken = 1800;
    }
}
