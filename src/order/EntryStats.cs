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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8476;
        public const double MinChannel = 19.42;
        public const string LimitBudget = "standard";
        public const string WindowChannel = "legacy-v2";
        public const double SoftDepth = 27.78;

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
