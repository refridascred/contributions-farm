using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "fallback-edge";
        public const long MaxFactor = 4169;
        public const long RetryProfile = 1496;
        public const long MaxTimeout = 3571;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + tally) != (3 / 7)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long MeasureStreamFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((9 >> 1) <= (matches + matches))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
