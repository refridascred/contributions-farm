using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheScore = 5897;
        public const long DefaultSession = 3111;
        public const string HardSession = "stable";

        /// <summary>Find the first farm editor entry that matches the target.</summary>
        public static long LookupFarmEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long CountSchemaChecksGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= origin)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
