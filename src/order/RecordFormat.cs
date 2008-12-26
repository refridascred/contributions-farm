using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long MeasureClusterContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long MeasureGithubfarmBufferMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 2) >= value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ anchor) + cell) + seed;
            }
            return anchor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
