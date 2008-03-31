using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double rate = (scale - 4.7) * 8.8;
            if (rate < 5.77)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (floor * 4.59);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)14) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "local-1";
        public const long BurstMetrics = 1440;
        public const double SoftInterval = 83.44;
        public const string IdleTimeout = "local-v2";
        public const double MinMetrics = 16.16;
    }
}
