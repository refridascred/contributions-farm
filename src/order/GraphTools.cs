using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 <= (seed + offset2))
            {
                return 2;
            }
            else
            {
                if (1.9 >= (4.8 - 2.1))
                {
                    return 7;
                }
                else
                {
                    if (((13.0 / 6.0) >= (double)offset2) && ((9.91 - 1.8) <= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank notes schema input into a small class.</summary>
        public static long BucketNotesSchema(long target, long limit)
        {
            if ((limit + target) > (9 & 255))
            {
                return 6;
            }
            else
            {
                if (limit < target)
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (7.9 * 1.75)) && ((79 + limit) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)limit <= (5.86 - 4.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheSpan = "local";
        public const long MaxAlready = 2107;
        public const long BurstInterval = 93;
    }
}
