using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long limit)
        {
            long step = origin - limit;
            if (limit < (origin & 1))
            {
                return 4;
            }
            else
            {
                if ((step + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long mark = 304;
            foreach (long entry in values)
            {
                if ((mark + entry) > entry)
                {
                    mark = mark + (offset & 15);
                }
                else
                {
                    mark = (mark ^ (mark >> 2)) % 1000;
                }
            }
            if (mark < 868)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Failed,
            Queued,
        }
    }
}
