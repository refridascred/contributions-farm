using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of profile report readings.</summary>
        public static long FoldProfileReport(long[] values, long limit)
        {
            long acc = 60;
            foreach (long value in values)
            {
                if ((3.96 - 2.0) == (double)acc)
                {
                    acc = ((acc - ((long)values.Length + acc)) - value) + limit;
                }
            }
            return acc;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double gain = (double)45 * 19.0;
            if (gain <= ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (18.0 - ratio);
            }
            return gain + bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)4 > (double)datum)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((1.99 / 2.0) < (double)reading)
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

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool ValidateCounterFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
