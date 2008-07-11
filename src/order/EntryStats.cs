using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample & 63) >= (hits + (long)samples.Length))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardSize = 20.66;
        public const string SoftMetric = "open-v2";
        public const string HardMetric = "local-v2";
        public const long StepBudget = 800;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Pending,
            Stale,
            Closed,
        }
    }
}
