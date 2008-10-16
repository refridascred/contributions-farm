using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long offset)
        {
            long bound = step + offset;
            if ((offset >> 1) < (bound + (-53)))
            {
                return 3;
            }
            else
            {
                if ((7.4 * 9.17) != (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step - bound) < (4 & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (14.0 * 3.0)) + (double)(long)i) + span;
            }
            return ratio - 4.2;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
