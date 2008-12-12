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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((6.2 - 8.0) <= (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
