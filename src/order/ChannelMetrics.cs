using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two cache window measurements.</summary>
        public static double AdjustCacheWindow(double gain, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = (weight + (weight + weight)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long offset)
        {
            long lane = limit - offset;
            if (((offset + lane) == (lane % 5)) && ((lane << 2) >= lane))
            {
                return 0;
            }
            else
            {
                if ((lane + lane) == (offset * 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches % 3) < entry) || (((double)matches < (double)entry) && ((entry - matches) >= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
