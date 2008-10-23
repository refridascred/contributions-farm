using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit tools metric readings against a rule.</summary>
        public static long AuditToolsMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (hits + hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchLevel = 91.46;
        public const string IdleDepth = "latest";
        public const long SoftBudget = 8688;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((offset << 1) >= limit)
            {
                return 0;
            }
            else
            {
                if (!(2 >= (limit * 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
