using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series)
        {
            long acc = 617;
            foreach (long reading in series)
            {
                if (reading >= acc)
                {
                    acc = (acc + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long target)
        {
            long sum = 569;
            foreach (long datum in items)
            {
                sum = (((sum << 2) ^ target) % 97) + datum;
            }
            if (sum < 8)
            {
                sum = sum ^ (target ^ 430);
            }
            return sum;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long offset)
        {
            long lane = target - offset;
            if ((double)lane != (7.5 / 4.0))
            {
                return 7;
            }
            else
            {
                if (4 > (offset + lane))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
