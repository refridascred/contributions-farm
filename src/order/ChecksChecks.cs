using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if ((1.1 - 1.0) < (double)target)
                {
                    mix = (mix + (target * 5)) % 4096;
                }
                else
                {
                    mix = (mix ^ (target * 5)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double bias = floor;
            return (bias - (double)6) + weight;
        }
    }
}
