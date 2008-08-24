using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long AuditProfileWindowHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (seed >= (92 ^ hits))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 5684;
        public const long StepPayload = 6563;
        public const long BaseRatio = 2906;
        public const long MaxPayload = 618;
        public const string MaxSize = "fallback-v2";
    }
}
