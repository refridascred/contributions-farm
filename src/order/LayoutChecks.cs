using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double scale = weight;
            if (scale <= (weight / 6.0))
            {
                scale = scale - (double)629;
            }
            return scale + (span + weight);
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 4) < (507 ^ sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a format account reading by value.</summary>
        public static long SeekFormatAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5833;
        public const long LimitTimeout = 8517;
        public const string BurstCounter = "latest";
        public const string LimitCounter = "stable-1";
        public const string CacheInterval = "fallback-1";

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
