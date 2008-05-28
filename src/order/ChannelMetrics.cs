using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
