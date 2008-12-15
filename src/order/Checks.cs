using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 4504;
        public const long StepTimeout = 3699;
        public const long MaxEditor = 8242;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if (((target * 5) > (target ^ seed)) && ((double)seed >= (double)target))
            {
                return 2;
            }
            else
            {
                if ((target % 7) <= target)
                {
                    return 0;
                }
                else
                {
                    if (!((seed % 64) >= (seed + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
