using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a stream report reading by value.</summary>
        public static long SeekStreamReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Queued,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepSpan = 63.53;
        public const string IdleRatio = "strict-v2";
        public const long BurstRecord = 3760;
    }
}
