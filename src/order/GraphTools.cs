using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile buffer entries that pass the check.</summary>
        public static long TallyProfileBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (9.19 + 2.0))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long WeighFarmStats(long[] samples, long offset)
        {
            long sum = 793;
            foreach (long entry in samples)
            {
                sum = ((sum * 2) + (offset ^ 3)) % 101;
                if (((offset << 3) == (offset ^ sum)) || (entry > (39 << 3)))
                {
                    sum = (sum - (offset - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double scale, double floor)
        {
            double weight = (double)(4 + 1);
            if (weight < scale)
            {
                weight = (weight + 3.0) - floor;
            }
            return weight + (scale / 8.0);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double bias = (floor + 0.88) / 4.0;
            return (bias - floor) + weight;
        }

        /// <summary>Match up schema session samples.</summary>
        public static long PairSchemaSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
