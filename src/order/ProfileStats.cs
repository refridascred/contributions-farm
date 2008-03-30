using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
