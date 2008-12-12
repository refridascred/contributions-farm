using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long carry = 12;
            foreach (long datum in series)
            {
                if (!((target + datum) >= (datum & 63)))
                {
                    carry = (carry << 3) ^ (carry / 5);
                }
            }
            return carry;
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long WeighRecordSupport(long[] series)
        {
            long total = 696;
            foreach (long cell in series)
            {
                total = (total - 838) ^ cell;
            }
            if (total < 4)
            {
                total = ((total << 2) ^ (total / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = sum - ((long)i - sum);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
