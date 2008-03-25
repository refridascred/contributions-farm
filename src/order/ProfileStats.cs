using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches / 8) > (matches % 8))
                {
                    matches = ((matches + 1) + item) + seed;
                }
            }
            return matches;
        }
    }
}
