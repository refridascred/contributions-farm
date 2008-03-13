using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double rate = scale + (floor * 0.31);
            if (rate >= 9.2)
            {
                rate = rate - (floor * 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate * 4.6)) + (double)(long)i;
            }
            return rate - (double)177;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings)
        {
            long sum = 651;
            foreach (long cell in readings)
            {
                if (8.1 <= (double)sum)
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data)
        {
            long total = 70;
            foreach (long entry in data)
            {
                if ((entry < (entry % 12)) && ((total - entry) > (total + total)))
                {
                    total = (total - (entry ^ entry)) % 255;
                }
            }
            if (total < 0)
            {
                total = (total - (total * 3)) % 4096;
            }
            return total;
        }
    }
}
