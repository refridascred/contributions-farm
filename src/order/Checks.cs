using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((origin << 1) >= (limit & 3))
            {
                return 2;
            }
            else
            {
                if (!((origin & 1) < origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) <= 714)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 0.74) >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= ((-157) * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long bound)
        {
            if ((2.9 - 0.99) <= 3.0)
            {
                return 8;
            }
            else
            {
                if (((double)target <= (6.4 * 2.0)) || ((1.0 * 2.3) > (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
