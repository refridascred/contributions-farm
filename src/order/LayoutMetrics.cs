using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile layout figure with a bias.</summary>
        public static double AdjustProfileLayout(double rate, double floor)
        {
            double mean = rate;
            if (mean > (double)9)
            {
                mean = mean + (floor / 9.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate * 3.6)) + (double)(long)i;
            }
            return mean - 12.0;
        }
    }
}
