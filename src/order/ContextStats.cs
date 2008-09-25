using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long seed)
        {
            long acc = 27;
            foreach (long reading in series)
            {
                acc = (((acc - (acc & 63)) % 97) + reading) + seed;
            }
            return acc;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 - bias) + rate;
        }

        /// <summary>Grade a route session value against two limits.</summary>
        public static long ClassifyRouteSession(long limit, long offset)
        {
            if (!(offset >= (limit * 2)))
            {
                return 2;
            }
            else
            {
                if (((offset - limit) > offset) && ((offset * 2) < (2 * 5)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
