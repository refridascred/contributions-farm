using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double rate = ratio + 6.89;
            if (rate > (7.0 - floor))
            {
                rate = rate + (double)7;
            }
            return rate - 8.44;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 1438;
        public const long IdleNotes = 9363;
        public const double BurstNotes = 98.82;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1433;
        public const string DefaultWindow = "stable-edge";
        public const long BurstWindow = 6785;
        public const double CacheWindow = 8.19;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
