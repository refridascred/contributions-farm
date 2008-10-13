using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long RankStreamRecord(long bound, long bound2)
        {
            if ((7.0 * 2.6) > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound2) >= (bound2 / 8))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long CountGraphWindowOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value <= 7.66)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.3 - 8.0) <= (0.6 / 5.0))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double drift = (double)(8 - 97);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + bias) + (double)(long)i) - bias2;
            }
            return drift - drift;
        }
    }
}
