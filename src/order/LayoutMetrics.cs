using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(((214 - tally) <= target) && ((66 + 16) < ((long)items.Length / 8))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count > (0 ^ 86)) || ((0 + 90) >= datum)) || ((datum >= (datum + datum)) || ((double)datum >= (7.0 + 7.6))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next order batches value from a seed.</summary>
        public static long RollOrderBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((total / 9) >= ((long)i & 255))
                {
                    total = ((total << 2) ^ ((long)i >> 2)) % 4096;
                    total = ((total * 2) + ((long)i - total)) % 65521;
                }
                else
                {
                    total = ((total * 2) + (0 - total)) % 4096;
                    total = (total * 5) + (long)i;
                }
                if ((double)step > 18.0)
                {
                    total = total + total;
                }
                total = (total - (total - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
