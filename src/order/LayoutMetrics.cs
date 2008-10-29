using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long origin)
        {
            if (floor < (origin + floor))
            {
                return 8;
            }
            else
            {
                if (3.22 >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((3.23 / 5.0) < (double)origin) || (floor <= (floor * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long GradeNotesChecks(long limit, long origin)
        {
            long prev = limit + origin;
            if ((prev + limit) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 5.0)
                {
                    return 6;
                }
                else
                {
                    if (!((prev ^ origin) != (origin ^ prev)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev >> 3) <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
