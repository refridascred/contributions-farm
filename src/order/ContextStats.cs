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

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

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

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 2048;
        public const long DefaultRatio = 2750;
        public const long HardFarm = 7199;
        public const long WindowDepth = 9821;
        public const long CacheInterval = 9404;
    }
}
