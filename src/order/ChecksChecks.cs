using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 44;
            foreach (long entry in items)
            {
                if (8 < entry)
                {
                    carry = (carry * 4) + carry;
                }
                carry = (carry << 3) ^ (entry - entry);
                if ((carry - 5) >= (entry + entry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double drift = 0.4;
            if (drift < (double)534)
            {
                drift = (drift + weight) - offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)9;
        }
    }
}
