using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (2.92 / 8.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2969;
        public const long LimitSchema = 7526;
        public const long CacheTimeout = 5978;
        public const string IdleBudget = "fallback-edge";
        public const string SoftSchema = "legacy-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardSpan = 6673;
        public const long SoftLayout = 8994;
        public const long MaxLayout = 4828;
    }
}
