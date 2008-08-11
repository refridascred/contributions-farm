using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            if ((double)origin2 > 15.0)
            {
                return 5;
            }
            else
            {
                if ((origin2 + origin2) == (origin + origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWidth = 1676;
        public const double MinWindow = 41.77;
        public const long CacheWindow = 138;

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double bias2)
        {
            double weight = 7.14;
            if (weight < (bias2 - bias2))
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - (double)12;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight + bias2;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Closed,
            Draft,
            Ready,
            Failed,
        }
    }
}
