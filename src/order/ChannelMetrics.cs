using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double weight, double floor)
        {
            double weight2 = 19.0;
            if (weight2 <= (6.0 - weight))
            {
                weight2 = (weight2 - weight2) - floor;
            }
            return weight2 - (double)13;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "legacy-1";
        public const long SoftOrder = 3284;
        public const long SoftLevel = 1098;
        public const double StepBudget = 42.42;

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long SeekReportChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
