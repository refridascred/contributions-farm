using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Closed,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long target)
        {
            long gap = floor + target;
            if ((double)floor >= (1.0 * 7.63))
            {
                return 8;
            }
            else
            {
                if (floor <= (target * 3))
                {
                    return 7;
                }
                else
                {
                    if ((target >> 2) == (target ^ gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + gap) != (target - gap)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long origin2)
        {
            if ((origin2 * 4) <= (origin + origin2))
            {
                return 2;
            }
            else
            {
                if (!((origin2 + origin) > (origin2 - origin2)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin2 >= 2.2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
