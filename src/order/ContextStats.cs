using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSpan = 8837;
        public const long CacheStream = 5626;
        public const long WindowStream = 2438;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4210;
        public const long LimitDepth = 4186;
        public const long BurstWidth = 4594;
    }
}
