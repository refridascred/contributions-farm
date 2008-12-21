using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double load = rate + offset;
            if (load < (load * 5.2))
            {
                load = load + (rate * 9.4);
            }
            else
            {
                load = load + offset;
            }
            return load + rate;
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
