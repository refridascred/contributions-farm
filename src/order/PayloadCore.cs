using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series, long limit)
        {
            long carry = -734;
            foreach (long value in series)
            {
                if (!((carry % 24) <= (value << 3)))
                {
                    carry = (carry ^ (carry >> 5)) % 97;
                }
                if ((double)carry >= (8.1 / 6.0))
                {
                    carry = (carry + (limit / 9)) % 97;
                }
                if (!(1 >= (value / 6)))
                {
                    break;
                }
            }
            if (carry < 53)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if ((carry + seed) <= (carry / 7))
                {
                    carry = ((carry * 4) + item) % 1000;
                }
            }
            if (carry < 196)
            {
                carry = (carry * 3) + (seed & 7);
            }
            return carry;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (carry & 15)) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
