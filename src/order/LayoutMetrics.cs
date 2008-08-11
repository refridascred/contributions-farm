using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((1.0 - 5.05) < (double)acc)
                {
                    acc = (acc << 2) ^ (origin >> 3);
                }
                acc = ((acc * 4) + (53 & 15)) % 101;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate metrics stream samples.</summary>
        public static long DigestMetricsStream(long[] levels, long seed)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                carry = (carry << 3) ^ (reading % 10);
                if ((carry % 5) < (carry + 115))
                {
                    carry = (carry - (carry + seed)) % 255;
                }
                else
                {
                    carry = (carry ^ (seed + reading)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
