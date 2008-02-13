using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first cluster metrics entry that matches the target.</summary>
        public static long FindClusterMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token cache series from a seed.</summary>
        public static long RollTokenCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstRatio = "local";
        public const long HardQueue = 7749;
        public const string CacheFactor = "local-v2";
        public const string DefaultLevel = "legacy-edge";
    }
}
