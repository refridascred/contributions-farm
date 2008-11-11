using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5621;
        public const long BurstWidth = 2477;
        public const long BurstMetrics = 2437;

        /// <summary>Count the batch support entries that pass the check.</summary>
        public static long TallyBatchSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((565 & 1) == (cell << 2)) && (cell > (cell + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double scale = 19.0;
            if (scale <= floor)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.08;
        }
    }
}
