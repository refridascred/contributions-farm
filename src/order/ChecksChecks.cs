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

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 2428;
        public const long WindowSupport = 4778;
        public const long BurstSupport = 6267;
        public const long HardDepth = 1428;
        public const long IdleCount = 2279;

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
