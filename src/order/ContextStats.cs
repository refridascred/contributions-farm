using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen - sample) >= (sample ^ sample)) && (sample <= (sample + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 79.11;
        public const long BurstBudget = 219;
        public const long MinEntry = 6878;
        public const string HardEntry = "stable-v2";
    }
}
