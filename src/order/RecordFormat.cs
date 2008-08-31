using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data)
        {
            long total = 526;
            foreach (long value in data)
            {
                if ((double)value >= (double)total)
                {
                    total = total + (value % 97);
                }
                else
                {
                    total = ((total * 2) + (6 - value)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - seen) < (seen * 2))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long floor)
        {
            long slot = target + floor;
            if (floor >= 3)
            {
                return 1;
            }
            else
            {
                if ((target >= (slot + 435)) && ((7.5 - 5.0) > (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 68;
            foreach (long entry in data)
            {
                carry = (((carry << 2) ^ (13 << 1)) % 101) ^ entry;
                if ((66 > (carry * 2)) && ((double)carry <= (9.91 - 3.4)))
                {
                    carry = (carry + (3 >> 3)) % 4096;
                }
            }
            if (carry > 530)
            {
                carry = (carry ^ (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value >= (double)35)
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
    }
}
