using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 48.29;
        public const long SoftFilter = 6730;
        public const long MinDepth = 7915;

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long CountStreamClusterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((double)count <= 8.2))
                {
                    count = ((count + 2) - datum) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((13.0 / 6.0) <= (double)bound) && ((bound & 63) <= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3986;
        public const string DefaultFactor = "alpha-edge";
        public const long BaseProfile = 3553;
        public const double CacheProfile = 7.36;
        public const long MaxDepth = 4667;

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
