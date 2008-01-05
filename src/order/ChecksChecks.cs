using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry << 1)) % 1000;
            }
            if (mark > 812)
            {
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitRatio = 1447;
        public const double BatchWidth = 79.35;
        public const string WindowBudget = "stable-v2";
        public const string BaseContext = "legacy-edge";
        public const string WindowDepth = "staging";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - hits) <= value)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
