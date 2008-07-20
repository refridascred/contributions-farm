using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(9.22 >= (double)bound))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long target)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = (((mark * 5) + (mark % 24)) % 255) + entry;
            }
            if (mark < 5)
            {
                mark = (mark << 2) ^ (target + target);
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double span)
        {
            double bias = (double)(1 - 384);
            if (bias <= span)
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias + (double)14;
            }
            return bias - 6.23;
        }
    }
}
