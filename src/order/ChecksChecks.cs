using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed + result) > (9 ^ result)) && (result < (7 + result)))
                {
                    result = ((result * 2) + (81 ^ result)) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
