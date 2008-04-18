using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6 <= (cell + 8)) && !((5.9 / 7.0) <= (double)cell))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Idle,
            Closed,
            Ready,
            Paused,
        }
    }
}
