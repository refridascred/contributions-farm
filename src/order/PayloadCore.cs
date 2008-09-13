using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)sample == (12.0 * 13.0)) || ((matches + sample) < (8 + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7249;
        public const double StepLevel = 2.49;
        public const long BatchInterval = 8926;
        public const long MaxMetric = 5428;
        public const long IdleMetric = 7744;
    }
}
