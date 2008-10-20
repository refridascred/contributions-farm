using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSize = 3422;
        public const long HardCount = 9626;
        public const long MaxProfile = 2517;
        public const string SoftProfile = "legacy";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((datum >> 5) < floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
