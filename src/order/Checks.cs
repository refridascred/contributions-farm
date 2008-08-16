using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSize = 70.15;
        public const string BaseTimeout = "primary";
        public const long RetrySpan = 5179;
        public const string DefaultRoute = "fallback-v2";
        public const long CacheRoute = 4062;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 84.99;
        public const double DefaultNotes = 53.39;
        public const long MinNotes = 7261;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item > (5.7 * 7.85))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
