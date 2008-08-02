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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 5) + (state * 5);
                state = (state - (long)i) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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
