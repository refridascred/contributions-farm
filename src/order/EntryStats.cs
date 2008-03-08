using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchRatio = 34.04;
        public const long MaxFactor = 1198;
        public const long HardContributi = 5912;
        public const string StepContributi = "local-v2";
        public const string WindowContributi = "primary-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((entry >> 2) > 68) && ((5.04 - 9.36) >= (double)tally)) || ((7.1 / 4.0) != (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
