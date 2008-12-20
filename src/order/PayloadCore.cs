using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the account entry series from a seed.</summary>
        public static long DeriveAccountEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (target & 7)) % 65521;
                state = (state ^ (long)i) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
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
