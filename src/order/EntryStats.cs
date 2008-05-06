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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long acc = 33;
            foreach (long entry in data)
            {
                if (entry > (origin ^ acc))
                {
                    acc = (acc << 3) ^ (157 / 5);
                }
                else
                {
                    acc = ((acc << 3) ^ entry) % 65521;
                }
            }
            return acc % 65521;
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

        /// <summary>Define order limits and defaults.</summary>
        public const string StepBudget = "cached-edge";
        public const long HardDepth = 8874;
        public const long HardOrder = 7050;
        public const long RetryOrder = 6124;
        public const long HardRatio = 9647;
    }
}
