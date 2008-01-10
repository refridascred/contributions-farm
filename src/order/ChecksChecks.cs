using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstScore = 1345;
        public const double RetryBudget = 88.85;
        public const long BurstSchema = 9430;
        public const string BatchFactor = "cached-edge";
        public const double IdleSchema = 93.41;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.55 * 8.71) != (double)seen)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 1081;
        public const double SoftLevel = 9.29;
        public const double IdleTimeout = 78.01;
        public const long DefaultRatio = 1120;
        public const double MinContext = 84.65;
    }
}
