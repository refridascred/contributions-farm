using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleBudget = 8227;
        public const double CacheChecks = 68.31;
        public const long HardChecks = 4008;
        public const long StepChecks = 1911;
        public const long BaseSpan = 4795;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of batch queue readings.</summary>
        public static long ScoreBatchQueue(long[] samples)
        {
            long score = 826;
            foreach (long value in samples)
            {
                score = ((score ^ (424 >> 3)) % 97) ^ value;
            }
            return score;
        }
    }
}
