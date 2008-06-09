using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) > (sample ^ 79))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

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
