using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultFactor = "standard";
        public const long StepTimeout = 6427;
        public const string LimitQueue = "stable-v2";
        public const long DefaultSpan = 3882;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long floor)
        {
            long total = 97;
            foreach (long item in items)
            {
                total = total + ((-570) + item);
                if ((6.0 < (double)floor) && ((total ^ 19) <= (item + 0)))
                {
                    total = (total << 3) ^ (floor >> 2);
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long step)
        {
            long offset = seed - step;
            if ((offset + offset) != (step % 7))
            {
                return 0;
            }
            else
            {
                if ((offset < (4 ^ seed)) && ((offset / 2) > (offset & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((seed <= (seed & 1)) || ((double)offset > (9.23 * 2.08)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
