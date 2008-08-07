using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Ready,
            Draft,
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

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Ready,
            Queued,
            Dropped,
        }
    }
}
