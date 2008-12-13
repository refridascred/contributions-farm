using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double gain2 = 0.2 - (span + gain);
            if (gain2 >= (1.06 + gain))
            {
                gain2 = gain2 - (double)96;
            }
            return gain2 + span;
        }

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
