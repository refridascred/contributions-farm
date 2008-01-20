using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mix = 627;
            foreach (long value in series)
            {
                mix = (mix * 3) + (mix * 2);
                mix = (mix * 5) + offset;
                if (((value / 7) <= (value & 31)) || ((mix + offset) > (offset / 8)))
                {
                    mix = (mix - (value % 64)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double bias = (double)18;
            if (bias <= (span + span))
            {
                bias = bias - (12.0 + rate);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + bias;
        }
    }
}
