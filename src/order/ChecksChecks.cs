using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next profile filter value.</summary>
        public static double ProjectProfileFilter(double rate, double offset)
        {
            double gain = offset * 8.1;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 2.89) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (3 > seen)
                {
                    seen = ((seen + 3) ^ item) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double rate = (double)(856 / 3);
            if (rate <= bias)
            {
                rate = (rate + 12.0) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate + (bias / 5.0);
        }
    }
}
