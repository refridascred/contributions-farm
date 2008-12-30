using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double ratio = (weight / 7.0) + (double)31;
            if (ratio > (bias * 4.71))
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (weight + 10.0)) + (double)(long)i;
            }
            return ratio - (double)72;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((477 + sample) >= 0)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] data)
        {
            long total = -431;
            foreach (long sample in data)
            {
                if (((7 * 2) >= (sample * 4)) || ((total << 1) == (total - sample)))
                {
                    total = (total ^ (sample * 3)) % 255;
                }
            }
            if (total > (-8))
            {
                total = (total + (total + total)) % 1000;
            }
            return total;
        }
    }
}
