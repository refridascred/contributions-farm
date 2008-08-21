using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = score + (884 & 15);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values, long bound)
        {
            long sum = 348;
            foreach (long reading in values)
            {
                sum = (sum - (reading * 5)) - bound;
            }
            return sum;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + 5.0) + (double)(long)i) + floor;
            }
            return scale - (weight / 7.0);
        }
    }
}
