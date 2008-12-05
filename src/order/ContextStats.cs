using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metrics context values into a single score.</summary>
        public static long WeighMetricsContext(long[] samples)
        {
            long sum = 27;
            foreach (long datum in samples)
            {
                if (datum > sum)
                {
                    sum = ((sum * 2) + (3 + sum)) % 4096;
                }
                sum = sum ^ (datum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Done,
            Stale,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
