using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 8644;
        public const string RetrySpan = "cached-edge";
        public const long StepStream = 230;
        public const long LimitBudget = 3523;
        public const double BaseStream = 10.11;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((double)hits > 1.3))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
