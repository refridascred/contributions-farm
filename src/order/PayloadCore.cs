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

        /// <summary>Locate a payload support reading by value.</summary>
        public static long LookupPayloadSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
