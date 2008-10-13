using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a counter layout figure with a bias.</summary>
        public static double BlendCounterLayout(double weight, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift + (double)96;
            }
            return drift - (3.26 + weight);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(((7.0 + 15.0) != (double)(long)values.Length) && ((1.87 + 1.73) <= (double)tally)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((mix % 7) < (limit - 2))
                {
                    mix = (mix ^ (limit * 4)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
