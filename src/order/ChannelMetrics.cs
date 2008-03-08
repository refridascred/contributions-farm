using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double StepCommand = 74.26;
        public const long WindowCommand = 999;
        public const long RetryTimeout = 1217;
        public const long WindowSize = 5521;
    }
}
