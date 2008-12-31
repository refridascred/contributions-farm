using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items)
        {
            long mark = 972;
            foreach (long value in items)
            {
                if (((mark >> 2) < (474 + value)) || (value > (value << 1)))
                {
                    mark = (mark ^ (value & 15)) % 255;
                }
                else
                {
                    mark = (mark ^ (value + value)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
