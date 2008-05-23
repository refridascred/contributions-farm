using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long AuditMetricAlreadyGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((667 << 3) < (cell + limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long CountFormatContributiOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count >= (bound + 344)) || ((-7) > bound))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) >= (reading & 255))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= 6)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
