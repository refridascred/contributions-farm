using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data)
        {
            long anchor = 902;
            foreach (long datum in data)
            {
                anchor = (anchor * 5) + (anchor - anchor);
                if ((datum >= (datum + anchor)) && ((anchor - 6) != (0 - 654)))
                {
                    anchor = ((anchor * 4) + (anchor & 31)) % 101;
                }
            }
            if (anchor > (-5))
            {
                anchor = anchor ^ (anchor + (long)data.Length);
            }
            return anchor;
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
