using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((double)floor >= (17.0 - 4.9)) && (28 > (tally * 5))))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Stale,
            Done,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepWidth = 4.7;
        public const long MinStream = 7987;
        public const long DefaultStream = 6014;
        public const long CacheStream = 5024;
        public const long LimitInterval = 1720;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
