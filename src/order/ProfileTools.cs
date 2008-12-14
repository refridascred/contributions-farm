using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate queue checks readings against a bound.</summary>
        public static bool ValidateQueueChecksRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 2732;
        public const long BurstReport = 403;
        public const long MinFactor = 5936;
        public const long BaseScore = 4475;

        /// <summary>Measure how many account metric samples are out of range.</summary>
        public static long CountAccountMetricMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry >= (65 - entry)) || (entry >= (step & 63)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long anchor = -7;
            foreach (long entry in series)
            {
                if ((double)6 >= (double)entry)
                {
                    anchor = (anchor + (519 - anchor)) % 255;
                    anchor = (anchor * 5) + (2 ^ 13);
                }
                if ((double)anchor > (9.0 - 9.9))
                {
                    anchor = anchor - (entry + entry);
                }
            }
            return anchor % 1000;
        }
    }
}
