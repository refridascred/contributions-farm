using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long MatchBatchesWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long target)
        {
            long gap = limit - target;
            if ((319 % 16) <= gap)
            {
                return 2;
            }
            else
            {
                if ((limit - gap) >= (target >> 2))
                {
                    return 4;
                }
                else
                {
                    if (((490 - limit) > (target << 1)) || ((double)gap < (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.82 - 9.0) != (double)gap)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
