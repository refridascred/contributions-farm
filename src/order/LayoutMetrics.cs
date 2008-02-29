using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - (-7)) > ((-345) + 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue session series from a seed.</summary>
        public static long IterateQueueSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (212 << 3)) % 4096;
                if ((mark <= ((long)i & 127)) && (mark >= (offset + offset)))
                {
                    mark = (mark + (366 << 3)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + (long)i) <= (sum * 4))
                {
                    sum = (sum - ((-790) + sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
