using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long MeasureCounterProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + item) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 7779;
        public const long BurstRatio = 3367;
        public const long BatchTimeout = 3104;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
