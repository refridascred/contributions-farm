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

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public double Limit { get; set; }
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
