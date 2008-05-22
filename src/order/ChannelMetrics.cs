using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 6604;
        public const long RetryBatches = 1281;
        public const long MinWidth = 1009;
        public const double WindowBatches = 12.21;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 984;
        public const long BatchScore = 4523;
        public const double MinLevel = 40.91;
        public const long IdleContributi = 4873;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((-956) >= (target ^ sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
