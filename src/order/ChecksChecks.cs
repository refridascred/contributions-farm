using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 4875;
        public const string MaxChecks = "fallback-1";
        public const long SoftChecks = 3828;
        public const long MaxFactor = 397;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor + datum) > (floor % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
