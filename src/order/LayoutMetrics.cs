using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long carry = 93;
            foreach (long datum in series)
            {
                if ((double)datum != (double)offset)
                {
                    carry = (carry ^ (offset % 10)) % 97;
                }
                else
                {
                    carry = (carry + (carry ^ offset)) % 65521;
                }
                if (((double)carry != (7.0 + 9.73)) || ((carry & 3) < datum))
                {
                    break;
                }
            }
            if (carry < 36)
            {
                carry = carry + (offset * 5);
            }
            return carry % 1000;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
