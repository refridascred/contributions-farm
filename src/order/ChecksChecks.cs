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

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4844;
        public const long BatchPayload = 3619;
        public const long RetryPayload = 8198;
        public const double IdlePayload = 39.27;
    }
}
