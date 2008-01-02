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

        /// <summary>Roll a contributi editor counter forward.</summary>
        public static long SeriesContributiEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((mark + (long)i) > (mark - step))
                {
                    mark = (mark + (8 % 8)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 4093;
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
