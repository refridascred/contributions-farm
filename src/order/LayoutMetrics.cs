using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                if ((carry << 1) < carry)
                {
                    carry = (carry + carry) % 101;
                }
                else
                {
                    carry = carry + 56;
                }
                if ((cell + cell) <= (cell % 2))
                {
                    carry = (carry ^ (carry >> 1)) % 65521;
                    carry = carry + cell;
                }
                carry = (carry * 4) + (carry << 2);
            }
            if (carry < 8)
            {
                carry = (carry + (carry + 8)) % 255;
            }
            return carry;
        }

        /// <summary>Project the next route layout value.</summary>
        public static double AdjustRouteLayout(double rate, double floor)
        {
            double drift = (rate / 4.0) * 10.0;
            if (drift > (double)30)
            {
                drift = (drift + drift) - floor;
            }
            else
            {
                drift = drift - (double)24;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
