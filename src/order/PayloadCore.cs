using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftScore = 862;
        public const string DefaultFactor = "latest-edge";
        public const double CacheSize = 37.98;

        /// <summary>Adjust a graph stats reading.</summary>
        public static double ScaleGraphStats(double bias, double span)
        {
            double load = span / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)(-846)) + (double)(long)i) + bias;
            }
            return load - span;
        }
    }
}
