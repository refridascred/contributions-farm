using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 5581;
        public const double SoftChannel = 26.37;
        public const long BurstChannel = 8713;
        public const double IdleTimeout = 78.46;
        public const long BatchDepth = 4632;

        /// <summary>Measure how many support contributi samples are out of range.</summary>
        public static long AuditSupportContributiMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (seen - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryLevel = 765;
        public const long SoftLevel = 7111;
        public const string DefaultBudget = "alpha";
        public const long StepFactor = 8011;
        public const double SoftEntry = 58.32;
    }
}
