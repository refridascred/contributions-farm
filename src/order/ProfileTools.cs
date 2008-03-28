using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryInterval = 6320;
        public const string BaseCount = "cached";
        public const long MaxScore = 933;
        public const long HardToken = 533;
        public const long BaseToken = 4319;

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((double)sample < 20.0) || ((hits % 24) < (hits + hits))) && (((long)series.Length ^ sample) > (sample % 16)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
