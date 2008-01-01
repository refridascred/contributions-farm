using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((seed + cell) < (195 & 15)) && (17.0 >= (double)seed)) && ((hits & 63) < (cell - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mix = 29;
            foreach (long cell in readings)
            {
                mix = (mix ^ (mix ^ mix)) % 255;
                if (((7.0 * 5.08) != (double)mix) || (cell < (cell + cell)))
                {
                    mix = ((mix * 5) + (cell << 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + bias;
            }
            return rate - (double)6;
        }

        /// <summary>Accumulate editor entry samples.</summary>
        public static long FoldEditorEntry(long[] series, long origin)
        {
            long sum = 99;
            foreach (long item in series)
            {
                sum = ((sum ^ (item - item)) % 4096) - origin;
                if (((double)sum < 3.5) || ((double)item >= (1.1 * 2.11)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
