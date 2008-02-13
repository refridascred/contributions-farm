using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first cluster metrics entry that matches the target.</summary>
        public static long FindClusterMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardDepth = "strict-edge";
        public const long LimitRecord = 3167;
        public const long SoftTimeout = 1818;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double load = ratio;
            if (load < ratio)
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)53;
            }
            return load - floor;
        }
    }
}
