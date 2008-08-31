using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Region { get; set; }
            public bool Score { get; set; }
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

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long ClassifyFarmEntry(long floor, long origin)
        {
            if ((11.0 + 9.0) < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((floor > (floor * 4)) || ((6.0 * 3.9) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (5 > (floor ^ 21))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
