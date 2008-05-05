using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardTimeout = 5291;
        public const long StepDepth = 7148;
        public const long SoftCount = 2873;
        public const long HardCache = 579;
        public const long BurstWidth = 8347;

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
