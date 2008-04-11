using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (509 - target);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
