using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell + hits) >= (cell << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long total = 36;
            foreach (long datum in readings)
            {
                if ((52 * 5) == (bound - total))
                {
                    total = total + (total % 8);
                }
                if (datum >= (bound + total))
                {
                    total = (total * 4) + (0 * 2);
                }
            }
            return total;
        }
    }
}
