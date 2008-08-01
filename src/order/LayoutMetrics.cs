using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + 22) != ((long)readings.Length >> 4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 468;
        public const long StepDepth = 8464;
        public const double SoftFactor = 75.32;
        public const string StepWindow = "alpha-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 57.21;
        public const string BaseMetric = "primary-v2";
        public const long HardMetric = 7737;
        public const long IdleMetric = 5656;
    }
}
