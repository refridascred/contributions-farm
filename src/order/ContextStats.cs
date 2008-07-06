using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor * 3) >= floor)
                {
                    continue;
                }
                else
                {
                    total = (total - (4 ^ total)) % 97;
                    total = (total + (total + total)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (datum + total)) % 97;
            }
            return total;
        }
    }
}
