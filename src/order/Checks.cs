using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)seen <= 2.0) || ((datum > (datum - datum)) && ((seen + 85) <= (seen * 4))))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long CountAlreadyEntryMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally - value) <= ((long)readings.Length % 2))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleRatio = 7909;
        public const long WindowQueue = 2039;
        public const double IdleInterval = 38.02;
        public const long StepQueue = 7769;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = 72;
            foreach (long datum in series)
            {
                anchor = anchor - (80 * 3);
                if (((double)anchor > (double)datum) || ((long)series.Length == (datum - 775)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
