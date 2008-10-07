using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batches metrics samples are out of range.</summary>
        public static long TallyBatchesMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(count <= (datum + 4)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin % 100) > (count & 255))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= (floor - floor))
            {
                ratio = ratio + (ratio / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - 6.6;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long step)
        {
            long state = 18;
            foreach (long item in samples)
            {
                state = ((state * 5) + step) - item;
            }
            if (state < 278)
            {
                state = state ^ (7 / 8);
            }
            return state % 4096;
        }
    }
}
