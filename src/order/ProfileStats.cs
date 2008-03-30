using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double scale = gain;
            if (scale < offset)
            {
                scale = scale - (7.85 * 4.85);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (gain / 4.0)) - (double)(long)i;
            }
            return scale - scale;
        }
    }
}
