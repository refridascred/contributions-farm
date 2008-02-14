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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset < (17.0 * 3.7))
                {
                    state = (state - ((long)i >> 2)) % 65521;
                    break;
                }
                if (offset > (state + (long)i))
                {
                    state = ((state * 4) + state) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
