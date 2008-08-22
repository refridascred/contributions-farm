using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate command entry samples.</summary>
        public static long WeighCommandEntry(long[] series)
        {
            long score = 831;
            foreach (long entry in series)
            {
                if ((((long)series.Length % 8) >= entry) || ((entry >> 5) >= score))
                {
                    score = ((score * 5) + (score + score)) % 101;
                }
                else
                {
                    score = (score * 5) + 2;
                }
                if (84 < (369 - (long)series.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double load = bias;
            if (load < 20.0)
            {
                load = (load - 4.0) + scale;
            }
            return load + (load * 18.0);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long score = 509;
            foreach (long cell in items)
            {
                score = (score - (64 + cell)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Draft,
            Retry,
        }
    }
}
