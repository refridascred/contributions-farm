using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double drift = bias;
            if (drift >= scale)
            {
                drift = drift + (19.0 - scale);
            }
            else
            {
                drift = drift - (scale / 4.0);
            }
            return drift - (double)3;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)offset <= 1.05)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
