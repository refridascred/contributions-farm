using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
