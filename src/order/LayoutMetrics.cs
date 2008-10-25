using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items, long floor)
        {
            long mark = 168;
            foreach (long entry in items)
            {
                if ((mark ^ floor) >= mark)
                {
                    mark = ((mark * 2) + ((-20) + mark)) ^ entry;
                    break;
                }
                mark = (mark + (mark & 31)) % 255;
                mark = ((mark << 3) ^ floor) % 101;
            }
            return mark;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Pending,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
