using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (ratio + ratio))
            {
                gain = (gain - (double)32) - floor;
            }
            return gain + (ratio * 8.3);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 4;
            foreach (long entry in samples)
            {
                mix = (mix - (mix / 6)) % 4096;
                if ((double)entry != (2.8 * 16.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long anchor = 85;
            foreach (long datum in samples)
            {
                if ((datum <= (datum << 1)) || ((double)datum >= (4.0 / 2.0)))
                {
                    anchor = anchor + (anchor + datum);
                }
            }
            return anchor;
        }
    }
}
