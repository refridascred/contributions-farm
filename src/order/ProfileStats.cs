using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (scale + 7.6) / 3.0;
            if (scale2 > (double)3)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (span + scale2);
            }
            return scale2 + span;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed - carry) >= (carry - carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
