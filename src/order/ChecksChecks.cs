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

        /// <summary>Look up the position of a commits buffer sample.</summary>
        public static long FindCommitsBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
