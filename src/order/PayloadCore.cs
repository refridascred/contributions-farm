using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftBudget = 54.05;
        public const long BaseWidth = 2460;
        public const string BurstContext = "alpha";

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (0.42 <= (double)floor)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (acc & 15);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
