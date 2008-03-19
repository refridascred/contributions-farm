using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum >= (29 / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples)
        {
            long carry = 520;
            foreach (long item in samples)
            {
                if ((20.0 + 7.0) >= (double)carry)
                {
                    carry = ((carry << 3) ^ (item + item)) % 101;
                }
            }
            if (carry < 532)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long CombineAlreadySupport(long[] samples)
        {
            long sum = 799;
            foreach (long value in samples)
            {
                sum = (sum - ((-39) ^ value)) % 97;
            }
            if (sum < 11)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (limit >= (limit - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
