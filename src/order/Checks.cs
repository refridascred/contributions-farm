using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitRatio = 3644;
        public const double CacheMetrics = 17.32;
        public const long CacheTimeout = 7897;
        public const long RetrySpan = 8598;
        public const string BaseMetrics = "fallback-v2";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
