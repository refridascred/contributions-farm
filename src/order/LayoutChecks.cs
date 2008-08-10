using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading <= (matches * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long target)
        {
            long gap = offset + target;
            if (((double)offset <= (1.27 * 7.7)) || ((gap - gap) == (target * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset >> 5) >= (gap - gap)) || ((double)offset == (6.9 - 7.2)))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (86 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((932 - offset) < gap) && ((offset - offset) >= (665 - 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long target)
        {
            if (47 >= (target << 3))
            {
                return 8;
            }
            else
            {
                if ((limit + target) >= 73)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream command samples are out of range.</summary>
        public static long TallyStreamCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((sample - sample) <= seen) || ((double)seen <= (0.1 * 8.5))) || ((((long)items.Length >> 4) <= (seen - seen)) && ((6.5 / 9.0) == (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
