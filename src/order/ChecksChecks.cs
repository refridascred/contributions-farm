using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long CountToolsQueueOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits <= (long)data.Length)
                {
                    hits = ((hits + 1) + item) - offset;
                }
            }
            return hits;
        }

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
