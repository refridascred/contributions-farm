using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long mark = 9;
            foreach (long cell in values)
            {
                if ((250 + cell) > (cell & 63))
                {
                    mark = (mark ^ (cell - cell)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (floor > (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((bound ^ 519) == (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    if (5 > (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ 54) != (origin << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long step)
        {
            long result = 113;
            foreach (long item in readings)
            {
                if (!(result <= (result * 2)))
                {
                    result = ((result + (result + 8)) + item) - step;
                }
            }
            if (result < 833)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }
    }
}
