using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 3628;
        public const long CacheStats = 3676;
        public const double BurstStats = 95.01;
        public const long StepScore = 6088;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long offset)
        {
            long result = -137;
            foreach (long entry in levels)
            {
                if ((entry >> 3) != (offset - result))
                {
                    result = (result << 3) ^ 46;
                }
                else
                {
                    result = (result - (result ^ offset)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
