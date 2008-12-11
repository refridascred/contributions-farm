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

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
