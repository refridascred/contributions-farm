using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit stream route readings against a rule.</summary>
        public static long AuditStreamRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((0 >= (matches + matches)) || (item < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double rate = span / 3.0;
            return rate + (weight / 7.0);
        }
    }
}
