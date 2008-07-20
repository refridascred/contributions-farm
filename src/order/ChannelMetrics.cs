using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)981)
            {
                gain = (gain - (double)66) + weight;
            }
            return gain + (double)6;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels, long bound)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if ((7.0 * 19.0) < (double)bound)
                {
                    break;
                }
                else
                {
                    result = ((result ^ (bound >> 5)) % 1000) + cell;
                }
                result = result - 632;
            }
            return result % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchRatio = 3010;
        public const long IdleWidth = 8702;
        public const long BurstFormat = 9424;
        public const long MaxFormat = 6765;
        public const string MaxWidth = "open-1";
    }
}
