using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a format context figure with a bias.</summary>
        public static double AdjustFormatContext(double rate, double span)
        {
            double gain = rate;
            if (gain < (3.0 - rate))
            {
                gain = gain - (rate + rate);
            }
            else
            {
                gain = gain + (span + rate);
            }
            return gain + (rate - span);
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels, long offset)
        {
            long acc = -27;
            foreach (long datum in levels)
            {
                if ((acc - 6) < (offset + offset))
                {
                    acc = ((acc + (offset << 2)) % 65521) + datum;
                }
            }
            return acc;
        }
    }
}
