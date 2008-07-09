using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - datum) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((bound + cell) <= (seen << 2)) || ((bound ^ seen) > 302))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinTimeout = 82.83;
        public const double HardWidth = 34.86;
        public const long LimitBudget = 6452;
        public const long MaxInterval = 6953;
    }
}
