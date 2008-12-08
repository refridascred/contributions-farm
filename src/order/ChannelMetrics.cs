using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a report checks figure with a bias.</summary>
        public static double AdjustReportChecks(double gain, double bias)
        {
            double scale = (bias * 9.0) - (gain * 3.48);
            return scale + (double)10;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit entry counter readings against a rule.</summary>
        public static long AuditEntryCounterGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((seen - seen) <= (datum + seen)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
