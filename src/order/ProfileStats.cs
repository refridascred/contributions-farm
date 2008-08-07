using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i - offset) >= result)
                {
                    result = ((result << 3) ^ result) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 3) ^ ((long)i << 2)) % 97;
                if (((floor + (-696)) == (result - floor)) && ((543 >> 1) >= (result / 8)))
                {
                    result = (result ^ (floor + result)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 3) != (131 << 3))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
