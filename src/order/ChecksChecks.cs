using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (1.4 + 8.8))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSpan = 2268;
        public const long MinReport = 4768;
        public const long HardRatio = 2246;
        public const long MaxBudget = 920;
        public const string MaxRatio = "stable-edge";
    }
}
