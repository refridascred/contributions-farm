using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Idle,
            Stale,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8820;
        public const long LimitTools = 4317;
        public const long CacheTimeout = 8408;
        public const long CacheTools = 3979;
        public const double WindowTools = 69.77;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
