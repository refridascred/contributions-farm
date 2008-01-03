using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count < (double)step)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "primary-v2";
        public const double BaseScore = 98.55;
        public const long MaxSpan = 3308;

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "strict-edge";
        public const long WindowScore = 8631;
        public const long BurstWindow = 6730;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9775;
        public const long BaseLayout = 7542;
        public const string BatchLayout = "strict-v2";
        public const long LimitSpan = 2027;

        /// <summary>Measure how many counter batch samples are out of range.</summary>
        public static long TallyCounterBatchMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((seen / 6) > (target + target)) && ((double)seen < (1.93 / 5.0))))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
