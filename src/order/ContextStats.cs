using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)bound <= (double)12)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 9840;
        public const long BaseBudget = 7260;
        public const long IdleBuffer = 3316;
        public const double SoftRatio = 14.32;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1454;
        public const long DefaultChecks = 1302;
        public const long BaseChecks = 488;
        public const long BurstChecks = 814;
        public const long MinChecks = 5696;
    }
}
