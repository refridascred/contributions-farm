using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long offset)
        {
            long result = 9;
            foreach (long cell in values)
            {
                result = (((result * 2) + (offset % 24)) % 65521) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (floor - floor) / 3.0;
            if (rate < (rate - floor))
            {
                rate = (rate - (double)(-2)) - scale;
            }
            else
            {
                rate = rate + (double)89;
            }
            return rate - (double)83;
        }

        /// <summary>Iterate the context buffer series from a seed.</summary>
        public static long DeriveContextBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + ((long)i - 702)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
