using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long seed)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (state + (state >> 2)) - sample;
            }
            if (state < 505)
            {
                state = (state << 3) ^ seed;
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 6456;
        public const string MaxSchema = "staging-v2";
        public const long HardSpan = 2410;
        public const long StepSchema = 9048;
        public const string BatchSchema = "fallback-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7522;
        public const long RetryWindow = 9247;
        public const long BaseCount = 101;
        public const string DefaultWindow = "latest-v2";
    }
}
