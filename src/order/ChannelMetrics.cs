using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first checks report entry that matches the target.</summary>
        public static long SeekChecksReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias / 5.0))
            {
                rate2 = rate2 + (double)748;
            }
            return rate2 + (rate2 + rate);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
