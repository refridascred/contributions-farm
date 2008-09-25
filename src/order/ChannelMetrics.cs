using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2158;
        public const double StepRatio = 68.16;
        public const string RetrySpan = "local-edge";
        public const double MinCounter = 84.63;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
