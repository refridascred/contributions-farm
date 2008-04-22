using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long origin)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                if ((double)1 <= (double)origin)
                {
                    acc = ((acc ^ origin) % 97) - entry;
                }
            }
            return acc;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 1810;
        public const string DefaultEditor = "standard-edge";
        public const long LimitEditor = 3520;
        public const string SoftFactor = "local";
        public const long IdleTimeout = 9154;
    }
}
