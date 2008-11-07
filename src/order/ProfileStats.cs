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

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long state = 65;
            foreach (long item in data)
            {
                state = (state << 2) ^ (state << 1);
                if (((state + state) < (item - 4)) || (item > (state % 24)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
