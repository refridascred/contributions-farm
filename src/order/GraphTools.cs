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

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (bound / 6)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum + bound) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 2) < (seen - seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
