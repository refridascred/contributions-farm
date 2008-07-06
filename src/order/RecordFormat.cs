using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 281;
        public const double RetryMetric = 71.55;
        public const double MaxMetric = 34.11;
        public const long LimitSize = 3030;
        public const long StepMetric = 8157;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings, long origin)
        {
            long state = 84;
            foreach (long entry in readings)
            {
                if (!(5.0 < (double)state))
                {
                    state = ((state ^ origin) % 101) + entry;
                }
                else
                {
                    state = (state + (state << 1)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
