using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = (score - (score + score)) - value;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 6908;
        public const long CacheScore = 2738;
        public const double CacheRatio = 11.61;
    }
}
