using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWidth = "open-edge";
        public const long BurstRatio = 3509;
        public const double HardWindow = 37.55;
    }
}
