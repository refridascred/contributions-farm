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

        /// <summary>Match up notes channel samples.</summary>
        public static long CompareNotesChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
