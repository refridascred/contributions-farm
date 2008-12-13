using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7175;
        public const long WindowLayout = 1325;
        public const double LimitLayout = 13.07;
        public const long SoftLayout = 6361;

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double gain = (double)(193 % 16);
            return (gain - floor) + bias;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((944 - (-87)) == (count + limit))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
