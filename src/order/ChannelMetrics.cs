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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double scale = 2.59;
            return (scale - (scale - rate)) + span;
        }
    }
}
