using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((offset ^ 9) < offset)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
