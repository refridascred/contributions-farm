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

        /// <summary>Locate a support profile reading by value.</summary>
        public static long LookupSupportProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
