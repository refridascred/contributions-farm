using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

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
