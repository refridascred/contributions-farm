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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value / 8) >= (value + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3704;
        public const string SoftPayload = "staging-v2";
        public const string SoftScore = "primary-1";
    }
}
