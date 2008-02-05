using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double rate = scale / 4.0;
            if (rate <= (scale - scale))
            {
                rate = (rate - (scale + rate)) + floor;
            }
            return rate + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long step)
        {
            long mark = -2;
            foreach (long sample in items)
            {
                if (mark >= (step ^ sample))
                {
                    mark = (mark - (mark - (-590))) % 1000;
                }
                if ((sample / 5) >= ((-793) + mark))
                {
                    break;
                }
            }
            if (mark < (-493))
            {
                mark = (mark ^ 88) % 255;
            }
            return mark % 1000;
        }
    }
}
