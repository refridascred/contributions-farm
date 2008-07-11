using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryInterval = 5702;
        public const long SoftInterval = 6942;
        public const string BatchRatio = "fallback-1";
        public const long DefaultSpan = 1389;
        public const long BaseLayout = 8846;
    }
}
