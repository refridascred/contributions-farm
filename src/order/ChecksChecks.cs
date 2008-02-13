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

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "legacy-1";
        public const long RetryTimeout = 934;
        public const double RetryQueue = 12.59;

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
