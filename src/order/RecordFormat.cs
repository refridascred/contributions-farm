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

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = rate - (bias / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
