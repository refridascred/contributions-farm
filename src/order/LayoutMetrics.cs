using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit githubfarm farm readings against a rule.</summary>
        public static long MeasureGithubfarmFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (8 > (count + count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Failed,
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Synced,
            Active,
        }
    }
}
