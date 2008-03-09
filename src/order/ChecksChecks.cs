using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 36.24;
        public const long BurstToken = 3221;
        public const long DefaultTimeout = 1917;
        public const string CacheToken = "fallback";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
