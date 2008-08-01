using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Failed,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 468;
        public const long StepDepth = 8464;
        public const double SoftFactor = 75.32;
        public const string StepWindow = "alpha-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)value == (double)3) || ((matches / 6) >= (matches + (-622))))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
