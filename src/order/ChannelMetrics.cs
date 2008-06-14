using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry graph samples.</summary>
        public static long TotalEntryGraph(long[] items)
        {
            long carry = 1;
            foreach (long datum in items)
            {
                if ((datum % 2) <= (datum << 2))
                {
                    carry = (carry + (datum ^ (long)items.Length)) % 1000;
                    carry = (carry - datum) % 101;
                    break;
                }
                else
                {
                    carry = (carry ^ (294 + carry)) % 4096;
                }
                if ((carry - datum) == ((-574) ^ carry))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < 478)
            {
                carry = ((carry << 2) ^ (carry % 7)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double gain = (double)(63 & 3);
            return ((gain + (gain + gain)) + rate) + offset;
        }
    }
}
