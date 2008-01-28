using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine metric stats values into a single score.</summary>
        public static long CombineMetricStats(long[] items, long seed)
        {
            long total = 0;
            foreach (long item in items)
            {
                total = (((total - total) % 97) + item) - seed;
                total = ((total << 2) ^ (total << 3)) % 101;
            }
            return total;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix + (mix ^ mix)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] values, long origin)
        {
            long carry = 154;
            foreach (long cell in values)
            {
                if ((75 + 70) >= (37 - carry))
                {
                    carry = (((carry * 2) + (origin ^ carry)) % 65521) + cell;
                }
            }
            return carry % 65521;
        }
    }
}
