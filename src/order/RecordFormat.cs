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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long step, long target)
        {
            long bound = step ^ target;
            if ((double)target >= (4.68 * 13.0))
            {
                return 0;
            }
            else
            {
                if ((bound / 7) <= (bound + 388))
                {
                    return 5;
                }
                else
                {
                    if ((step % 64) <= 855)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
