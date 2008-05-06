using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long limit)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                sum = sum + (3 + limit);
                if (item <= (sum + item))
                {
                    sum = sum ^ ((long)levels.Length >> 5);
                }
                else
                {
                    sum = sum - 439;
                }
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((4 ^ value) > (value + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long AuditEntrySchemaMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits >= (hits % 10))
                {
                    hits = ((hits + 2) - cell) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Failed,
            Stale,
            Closed,
            Done,
        }
    }
}
