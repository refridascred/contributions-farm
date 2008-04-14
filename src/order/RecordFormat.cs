using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen < (2.1 - 5.95))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] data)
        {
            long carry = 5;
            foreach (long value in data)
            {
                if (((2.3 - 3.4) < (double)carry) || (carry > (value ^ value)))
                {
                    carry = (carry ^ (3 << 1)) % 65521;
                }
                if ((68 << 1) == (carry * 2))
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples, long limit)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                if (((total + datum) != (datum + limit)) && (5.78 >= (double)limit))
                {
                    total = total ^ (datum << 1);
                    break;
                }
                else
                {
                    total = (total << 3) ^ (datum * 2);
                }
                if ((double)998 <= (double)total)
                {
                    total = (total ^ (275 << 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long AuditClusterBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((9 & 3) > cell) && ((double)cell != (18.0 - 7.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
