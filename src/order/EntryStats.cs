using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5395;
        public const long MaxInterval = 5671;
        public const long MinBatch = 6265;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor - 77) - seed;
                anchor = (anchor ^ (anchor + cell)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long CountProfileLayoutOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((10 + datum) <= (floor + datum)) && ((20.0 / 4.0) > 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
