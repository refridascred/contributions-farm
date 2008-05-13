using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first entry profile entry that matches the target.</summary>
        public static long SeekEntryProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 8762;
        public const long SoftAlready = 3440;
        public const long MinAlready = 439;
        public const long HardLevel = 8407;

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 76.2;
        public const long DefaultLevel = 3380;
        public const string IdleBatch = "latest-v2";
        public const string CacheBatch = "stable-edge";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
