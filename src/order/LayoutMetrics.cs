using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3704;
        public const string SoftPayload = "staging-v2";
        public const string SoftScore = "primary-1";
    }
}
