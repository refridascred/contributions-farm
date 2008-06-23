using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "staging-edge";
        public const long WindowBudget = 6730;
        public const long MaxRatio = 649;
        public const long BatchInterval = 8500;
        public const string DefaultFactor = "staging-edge";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((-9) > seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Pending,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
