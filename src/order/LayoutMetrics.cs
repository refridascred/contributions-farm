using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry token readings.</summary>
        public static long FoldEntryToken(long[] samples, long floor)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((cell % 10) == (cell + cell))
                {
                    score = (score * 4) + (floor - floor);
                }
                score = score ^ (74 - score);
                if ((score - score) >= (cell + cell))
                {
                    break;
                }
            }
            return score % 4096;
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
