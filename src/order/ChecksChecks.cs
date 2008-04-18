using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double mean = gain;
            if (mean < (gain + 7.0))
            {
                mean = mean + (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean * 2.3)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double weight = 15.0 - floor;
            if (weight >= weight)
            {
                weight = (weight - (weight + floor)) + scale;
            }
            else
            {
                weight = weight + (floor - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - 6.2;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < ((-726) + entry))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
