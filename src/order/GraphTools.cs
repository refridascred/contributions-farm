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

        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long CountMetricsCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
