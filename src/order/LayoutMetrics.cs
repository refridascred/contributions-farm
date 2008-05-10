using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long acc = 1;
            foreach (long reading in series)
            {
                if (((acc << 1) >= (acc - reading)) || ((double)acc > (9.5 * 12.0)))
                {
                    acc = ((acc * 3) + reading) % 255;
                }
            }
            if (acc < 59)
            {
                acc = (acc - (acc >> 1)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long limit)
        {
            long sum = 9;
            foreach (long datum in values)
            {
                if (((limit * 3) >= (limit >> 5)) && ((double)sum >= (double)datum))
                {
                    sum = (sum - (limit >> 3)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
            }
            if (sum < 734)
            {
                sum = (sum ^ (limit - 652)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long total = 229;
            foreach (long datum in values)
            {
                if ((total + total) > total)
                {
                    total = (total ^ (datum >> 4)) + target;
                }
            }
            return total;
        }
    }
}
