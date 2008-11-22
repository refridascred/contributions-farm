using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Draft,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches & 255) >= (31 ^ matches))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
