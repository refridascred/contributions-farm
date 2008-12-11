using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double load = (double)4 * 1.0;
            if (load < bias)
            {
                load = (load + (load / 8.0)) - offset;
            }
            else
            {
                load = load - bias;
            }
            return load + (double)284;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((item - item) < ((-219) + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
