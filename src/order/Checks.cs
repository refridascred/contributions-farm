using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long floor)
        {
            long state = 61;
            foreach (long cell in series)
            {
                state = (((state << 3) ^ (70 / 6)) % 255) ^ cell;
            }
            if (state < 503)
            {
                state = (state ^ (state - floor)) % 101;
            }
            return state % 97;
        }
    }
}
