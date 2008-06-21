using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double load = (floor - floor) - floor;
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                mark = (((mark * 3) + (0 + mark)) % 1000) + target;
                mark = (mark + (entry / 5)) % 65521;
                if (!(43 >= (entry + mark)))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long TallyRouteFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((5.3 * 2.0) < (double)tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double rate = scale;
            if (rate < 8.21)
            {
                rate = rate - 6.14;
            }
            return rate - (scale - offset);
        }
    }
}
