using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels)
        {
            long total = 78;
            foreach (long value in levels)
            {
                total = (total << 2) ^ (value / 4);
            }
            return total % 65521;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length - (-112)) == ((-1) - hits)) && ((datum + hits) != ((long)items.Length + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
