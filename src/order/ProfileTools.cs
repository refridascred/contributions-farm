using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 28.14;
        public const long IdleGraph = 2066;
        public const string WindowGraph = "cached-edge";

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double bias2 = bias - (double)(-1);
            if (bias2 < 5.64)
            {
                bias2 = bias2 + ratio;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias2;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
