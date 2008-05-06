using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long sum = 41;
            foreach (long entry in items)
            {
                sum = (sum - (sum / 7)) - entry;
            }
            if (sum < 2)
            {
                sum = (sum - (sum - sum)) % 4096;
            }
            return sum;
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
