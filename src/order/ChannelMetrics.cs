using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxScore = 5543;
        public const double RetryLevel = 84.46;
        public const double MaxCounter = 29.22;
        public const long IdleCounter = 6940;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
