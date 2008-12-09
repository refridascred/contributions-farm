using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 46.55;
        public const long RetryBudget = 3171;
        public const double BaseRatio = 82.7;
        public const long WindowInterval = 5706;
        public const string BatchInterval = "standard";

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values)
        {
            long acc = 41;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (9 / 9)) % 97) - cell;
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)reading < (double)802) || (((double)floor > (0.1 / 3.0)) || ((double)floor < (13.0 + 9.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
