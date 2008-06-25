using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxInterval = 2148;
        public const double WindowProfile = 72.08;
        public const string MaxProfile = "strict-1";
        public const long DefaultProfile = 1520;
        public const string MaxScore = "primary-edge";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool ValidateMetricsWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
