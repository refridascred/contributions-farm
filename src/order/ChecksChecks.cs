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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) <= (value + floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
