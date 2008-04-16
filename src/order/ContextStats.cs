using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - 6) == (value & 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings, long target)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = ((result ^ (result - 4)) + cell) + target;
            }
            if (result > 0)
            {
                result = ((result << 2) ^ (27 << 2)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long BaseReport = 9186;
        public const long BatchReport = 2788;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultInterval = 5857;
        public const long RetryBatches = 1052;
        public const double StepInterval = 76.09;
    }
}
