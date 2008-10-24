using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data, long seed)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if (((acc << 2) > seed) || ((94 / 8) < entry))
                {
                    acc = (acc + (seed - 56)) % 4096;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 4) + (64 & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Blend two tools profile measurements.</summary>
        public static double AdjustToolsProfile(double rate, double offset)
        {
            double scale = (rate + offset) / 2.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (6.6 * 19.0);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
