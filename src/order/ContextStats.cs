using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = (floor - floor) * 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 4.0) + (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3737;
        public const long BurstSpan = 8758;
        public const long CacheStats = 9233;
        public const long MinSize = 1965;

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values, long origin)
        {
            long mark = 860;
            foreach (long item in values)
            {
                mark = (((mark + mark) % 101) - item) - origin;
                if ((813 > (811 - mark)) || ((double)mark == (8.8 * 5.8)))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings)
        {
            long total = 195;
            foreach (long value in readings)
            {
                total = ((total << 2) ^ total) ^ value;
            }
            if (total > 8)
            {
                total = (total + (total ^ total)) % 97;
            }
            return total;
        }
    }
}
