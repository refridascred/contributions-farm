using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long target)
        {
            if ((double)target < (5.5 * 6.7))
            {
                return 7;
            }
            else
            {
                if ((target ^ target) <= (target + origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
