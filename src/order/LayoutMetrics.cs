using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long score = 65;
            foreach (long reading in series)
            {
                if (((score << 1) <= 99) || ((7 & 15) != (reading % 12)))
                {
                    score = (score - (score & 1)) % 97;
                }
                if (score >= (reading << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 7744;
        public const string RetryDepth = "legacy-1";
        public const double RetryBatches = 86.54;
    }
}
