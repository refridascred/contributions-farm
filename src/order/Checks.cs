using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long RankAlreadyCommand(long bound, long bound2)
        {
            if ((bound - (-631)) > (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two notes counter measurements.</summary>
        public static double ProjectNotesCounter(double scale, double span)
        {
            double scale2 = scale + (scale + scale);
            if (scale2 < span)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - (scale2 - span)) - (double)(long)i;
            }
            return scale2 - 0.1;
        }

        /// <summary>Blend two already cache measurements.</summary>
        public static double SmoothAlreadyCache(double rate, double bias)
        {
            double weight = bias;
            if (weight < bias)
            {
                weight = (weight - bias) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)556;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Locked,
            Closed,
        }
    }
}
