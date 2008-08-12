using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 3) ^ (total - total)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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
