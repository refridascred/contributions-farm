using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
