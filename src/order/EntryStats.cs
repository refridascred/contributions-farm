using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardCount = 9642;
        public const long SoftSession = 4297;
        public const long BatchSession = 5676;
        public const long CacheSession = 8525;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultWidth = 5598;
        public const double DefaultSize = 58.33;
        public const long DefaultInterval = 3176;
        public const string LimitRatio = "latest-1";

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "local-v2";
        public const long BaseCommand = 4944;
        public const long MaxCommand = 2966;
        public const double CacheCommand = 37.11;
    }
}
