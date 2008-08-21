using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultLevel = "cached-edge";
        public const string LimitCache = "fallback-v2";
        public const double DefaultCache = 26.43;

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report notes value against two limits.</summary>
        public static long RankReportNotes(long step, long limit)
        {
            long lane = step + limit;
            if (lane >= (858 - lane))
            {
                return 8;
            }
            else
            {
                if (((double)lane > (double)limit) || ((lane >> 5) != (lane ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first support record entry that matches the target.</summary>
        public static long FindSupportRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
