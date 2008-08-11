using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) == (hits + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSize = "staging";
        public const long WindowCount = 1505;
        public const string CacheProfile = "cached-v2";
    }
}
