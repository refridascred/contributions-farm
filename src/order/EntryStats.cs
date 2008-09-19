using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the entry record entries that pass the check.</summary>
        public static long MeasureEntryRecordGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count * 5) != (count & 1))
                {
                    count = ((count + 3) - entry) - offset;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 5067;
        public const long IdleBatches = 1059;
        public const long WindowInterval = 6818;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - 2) <= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long CountReportFarmGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count > (count / 5))
                {
                    count = ((count + 2) + item) - limit;
                }
            }
            return count;
        }
    }
}
