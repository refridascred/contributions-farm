using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 4748;
        public const double MaxBudget = 88.48;
        public const long LimitContext = 4568;
        public const long HardContext = 9009;
        public const double BaseDepth = 74.04;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (mark / 6);
                mark = (mark + (seed + seed)) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((25 > (value - 5)) || ((matches % 60) <= (value ^ value))) && (((value * 5) < value) && (matches > (matches - value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
