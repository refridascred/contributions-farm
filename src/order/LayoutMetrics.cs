using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstTimeout = 9764;
        public const string BatchSpan = "stable-edge";
        public const long StepBudget = 1012;
    }
}
