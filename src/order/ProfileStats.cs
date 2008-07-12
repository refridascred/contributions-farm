using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long floor)
        {
            long result = -891;
            foreach (long cell in values)
            {
                if ((double)result >= (2.3 * 3.0))
                {
                    result = ((result - (1 * 3)) % 1000) + cell;
                }
                else
                {
                    result = result - (result * 3);
                }
            }
            if (result < 19)
            {
                result = result + floor;
            }
            return result % 4096;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Retry,
            New,
            Draft,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Pending,
            Stale,
        }
    }
}
