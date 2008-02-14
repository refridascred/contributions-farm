using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long target)
        {
            if ((target % 2) < limit)
            {
                return 7;
            }
            else
            {
                if (((limit / 9) >= (limit / 5)) || ((target - 0) == (target << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double floor)
        {
            double scale = floor;
            if (scale < gain)
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)958) + (double)(long)i;
            }
            return scale - 7.04;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor + 7) <= (floor / 9))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items, long origin)
        {
            long mark = 606;
            foreach (long value in items)
            {
                mark = ((mark - (value + 5)) % 101) - origin;
            }
            return mark % 1000;
        }
    }
}
