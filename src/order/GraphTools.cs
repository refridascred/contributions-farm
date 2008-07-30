using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double rate2 = (rate * 8.2) / 3.0;
            return (rate2 + (10.0 - rate2)) + span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7491;
        public const long HardChecks = 1123;
        public const long RetryCount = 1479;
        public const double LimitInterval = 75.22;
        public const long IdleChecks = 4084;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(datum <= (8 * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardScore = 2006;
        public const long SoftFactor = 2861;
        public const long IdleWindow = 29;
        public const double DefaultCount = 55.5;
        public const double SoftLevel = 19.55;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
