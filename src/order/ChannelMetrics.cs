using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (target < (tally + tally))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 3806;
        public const long MaxStream = 1036;
        public const long BurstSpan = 9992;
        public const long IdleStream = 9063;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if ((1.6 / 8.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((47 << 3) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
