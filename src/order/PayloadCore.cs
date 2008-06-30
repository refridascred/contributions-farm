using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long mark = 14;
            foreach (long sample in readings)
            {
                if (((double)mark >= (5.43 + 5.7)) || (((long)readings.Length + mark) == (mark - 972)))
                {
                    mark = ((mark - sample) % 1000) + step;
                }
                else
                {
                    mark = ((mark << 2) ^ (sample + mark)) % 1000;
                }
            }
            if (mark > 9)
            {
                mark = mark - (mark / 5);
            }
            return mark;
        }

        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool GuardGraphContextLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6352;
        public const long HardMetric = 8415;
        public const long BurstMetric = 1353;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Paused,
            Failed,
        }
    }
}
