using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (double)(-258))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate format cluster readings against a bound.</summary>
        public static bool GuardFormatClusterLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 2048;
        public const string BaseStream = "primary-1";
        public const double LimitInterval = 41.55;
    }
}
