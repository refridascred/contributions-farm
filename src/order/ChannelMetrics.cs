using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double scale = bias2;
            return scale + (bias * 2.6);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "cached-edge";
        public const string StepWindow = "legacy-1";
        public const string SoftWindow = "strict-edge";
        public const long CacheSpan = 8185;
        public const long BaseWidth = 4931;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Idle,
            Paused,
        }
    }
}
