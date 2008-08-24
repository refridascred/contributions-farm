using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowWidth = 7361;
        public const long SoftTimeout = 6007;
        public const string RetrySize = "legacy-1";
        public const string DefaultStream = "strict-v2";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-35) / 5) <= count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
