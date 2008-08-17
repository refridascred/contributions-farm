using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double drift = (6.94 / 5.0) / 4.0;
            if (drift > bias)
            {
                drift = (drift - drift) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - 3.2;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
