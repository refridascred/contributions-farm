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

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 2;
            foreach (long datum in items)
            {
                if ((1 << 1) >= datum)
                {
                    result = result ^ (result << 2);
                }
            }
            if (result < 60)
            {
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (3.98 < (double)origin)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
