using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 7718;
        public const string CacheSize = "alpha-v2";
        public const string HardFactor = "staging-v2";
        public const long MaxNotes = 6461;
        public const long BatchNotes = 3946;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 3116;
        public const string WindowScore = "open-v2";
        public const string MaxRatio = "latest-v2";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) >= (origin + origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile tools series from a seed.</summary>
        public static long RollProfileTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
