using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stats command figure with a bias.</summary>
        public static double SmoothStatsCommand(double weight, double span)
        {
            double gain = 1.1;
            if (gain >= gain)
            {
                gain = (gain - 9.83) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (8.24 + gain)) - (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Count context window pairs that satisfy a relation.</summary>
        public static long PairContextWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = ratio - (ratio + floor);
            if (rate <= (double)5)
            {
                rate = rate - (floor - floor);
            }
            return rate + (floor / 9.0);
        }
    }
}
