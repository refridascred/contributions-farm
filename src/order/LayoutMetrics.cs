using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data)
        {
            long carry = 39;
            foreach (long datum in data)
            {
                carry = carry ^ datum;
                if ((datum - carry) < datum)
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long limit)
        {
            long sum = 46;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ value) % 97;
                if ((value - limit) != (value + sum))
                {
                    sum = ((sum * 3) + 2) % 65521;
                    sum = (sum - ((long)series.Length - 552)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (limit + limit)) % 65521;
                }
                if ((limit > (6 % 24)) || (((long)series.Length & 127) < (limit - value)))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
                if ((double)limit > (double)31)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
