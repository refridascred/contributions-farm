using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long limit)
        {
            long next = target - limit;
            if ((target > (80 - target)) || ((next - target) == (216 << 1)))
            {
                return 7;
            }
            else
            {
                if (!((limit & 63) > (limit - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 127) >= (limit * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
