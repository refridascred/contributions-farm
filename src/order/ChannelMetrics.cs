using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((58 - value) > (value << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if (((mark + 402) > (262 + mark)) || ((double)value <= (4.22 + 9.53)))
                {
                    mark = (mark - value) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3048;
        public const double StepSchema = 60.59;
        public const string DefaultFactor = "strict-edge";
    }
}
