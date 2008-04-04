using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double bias = (scale / 4.0) / 3.0;
            return (bias + (double)82) + span;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double rate = weight / 5.0;
            if (rate < weight)
            {
                rate = rate + (offset / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)3;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 4328;
        public const long LimitBudget = 9688;
        public const double RetryContext = 22.9;

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (1 - (long)i)) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
