using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double load = (scale / 3.0) - scale;
            if (load >= (7.48 - load))
            {
                load = load + (6.97 / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) - (double)(long)i;
            }
            return load + (0.74 / 2.0);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
