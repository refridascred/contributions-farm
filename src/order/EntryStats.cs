using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count % 12) <= target) || ((sample % 3) < (target + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit window counter readings against a rule.</summary>
        public static long CountWindowCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits < 0.41)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples)
        {
            long result = 0;
            foreach (long item in samples)
            {
                if (((item - item) >= result) && ((item + item) <= (item ^ result)))
                {
                    result = result + (result * 4);
                }
                else
                {
                    result = ((result << 3) ^ (result * 4)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((816 ^ entry) > entry)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
