using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheWidth = "fallback-v2";
        public const string CachePayload = "staging";
        public const long RetrySize = 1410;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                long slot = ((long)i % 7) >> 2;
                if (!(slot >= ((long)i >> 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 9972;
        public const long BaseBuffer = 3840;
        public const string IdleBuffer = "strict-v2";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (19.0 * 4.86))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
