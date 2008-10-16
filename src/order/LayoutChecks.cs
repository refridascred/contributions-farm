using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((target ^ matches) < (matches << 1))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((12.0 * 6.57) >= (double)seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits channel samples are out of range.</summary>
        public static long MeasureCommitsChannelHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((537 >> 2) != (entry * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const long BurstDepth = 4960;
        public const double IdleSpan = 78.0;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
