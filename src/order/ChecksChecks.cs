using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double bias3 = bias - bias;
            if (bias3 <= (double)(-8))
            {
                bias3 = bias3 + bias2;
            }
            else
            {
                bias3 = bias3 + (double)4;
            }
            return bias3 + (double)(-3);
        }
    }
}
