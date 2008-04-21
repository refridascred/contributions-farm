using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9813;
        public const long BatchBudget = 846;
        public const long LimitWidth = 6640;
        public const long MaxToken = 2301;
        public const long BaseCount = 7286;

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 48.72;
        public const long IdleFactor = 7891;
        public const long BatchInterval = 4699;
        public const long HardContext = 7584;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long result = 931;
            foreach (long cell in series)
            {
                if ((31 & 7) < (cell * 4))
                {
                    result = (result << 2) ^ cell;
                }
            }
            return result;
        }
    }
}
