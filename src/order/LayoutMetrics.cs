using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen != (8.04 / 5.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double gain = (double)(3 * 5);
            if (gain >= (8.6 + gain))
            {
                gain = (gain - gain) - floor;
            }
            else
            {
                gain = gain - 6.0;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain + (gain - rate);
        }
    }
}
