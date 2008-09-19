using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached-1";
        public const long WindowFactor = 7741;
        public const long CacheDepth = 9233;
        public const long IdleBudget = 282;
        public const long CacheTools = 5101;

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
