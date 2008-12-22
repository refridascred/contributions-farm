using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cache counter input into a small class.</summary>
        public static long ClassifyCacheCounter(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((seed % 64) <= seed)
            {
                return 5;
            }
            else
            {
                if (((seed ^ origin) >= (817 << 2)) && (span >= (origin ^ origin)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
