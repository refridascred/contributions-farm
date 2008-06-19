using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
