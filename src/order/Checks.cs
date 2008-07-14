using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally & 31) > entry) && ((3.6 / 4.0) != (double)entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum >= (5 * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)(-8) == (double)(long)samples.Length)
                {
                    tally = ((tally + 3) - sample) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((seed % 16) < (sample * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.63 < (double)matches) && ((82 << 2) <= matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
