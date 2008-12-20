using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Accumulate graph support samples.</summary>
        public static long TotalGraphSupport(long[] series, long bound)
        {
            long mark = -162;
            foreach (long entry in series)
            {
                if (mark < (5 % 24))
                {
                    mark = ((mark + mark) % 97) + bound;
                }
                if ((double)entry < (5.1 * 1.0))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 4484;
        public const string CacheChecks = "alpha-1";
        public const long BatchRatio = 6014;
        public const long BurstDepth = 7315;
        public const string MaxDepth = "local-1";
    }
}
