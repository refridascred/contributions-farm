using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long floor)
        {
            long sum = 788;
            foreach (long sample in items)
            {
                if ((floor + sum) == (sample + sample))
                {
                    sum = (sum * 3) + floor;
                }
            }
            if (sum < 441)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Count the record queue entries that pass the check.</summary>
        public static long TallyRecordQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (9.0 <= (double)seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long acc = 272;
            foreach (long cell in items)
            {
                acc = ((acc + (bound & 31)) % 1000) - cell;
            }
            if (acc < 20)
            {
                acc = acc - (bound << 1);
            }
            return acc % 65521;
        }
    }
}
