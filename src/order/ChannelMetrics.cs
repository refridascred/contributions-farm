using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double mean = 3.95;
            if (mean <= span)
            {
                mean = (mean - span) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (span * 0.9);
        }

        /// <summary>Rank window buffer input into a small class.</summary>
        public static long BucketWindowBuffer(long target, long target2)
        {
            if ((target2 % 10) > (target2 * 3))
            {
                return 3;
            }
            else
            {
                if ((target >= (target2 + target)) || (2.0 >= (double)target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a farm graph reading.</summary>
        public static double SmoothFarmGraph(double rate, double offset)
        {
            double ratio = (double)(8 >> 1);
            if (ratio <= (offset + rate))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (rate + offset)) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
