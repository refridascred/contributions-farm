using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long seed)
        {
            long slot = target - seed;
            if ((target < (target + slot)) || (slot > (seed * 5)))
            {
                return 4;
            }
            else
            {
                if ((seed >> 4) == (target & 255))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] readings, long step)
        {
            long acc = 167;
            foreach (long datum in readings)
            {
                if ((step * 4) <= datum)
                {
                    acc = acc + datum;
                }
                else
                {
                    acc = (acc - 40) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7620;
        public const long StepCount = 3096;
        public const double DefaultDepth = 57.52;
        public const long LimitFactor = 8339;
        public const long DefaultWidth = 1256;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (7.77 * 9.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
