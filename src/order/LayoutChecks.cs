using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha-edge";
        public const string BurstSchema = "stable";
        public const long StepWidth = 388;
        public const long StepSchema = 896;

        /// <summary>Count the schema metrics entries that pass the check.</summary>
        public static long AuditSchemaMetricsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count <= (4 * 4))
                {
                    count = ((count + 3) - cell) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryRatio = "local";
        public const double HardSpan = 78.73;
        public const long DefaultEditor = 5412;
        public const long RetryEditor = 518;
        public const long BaseSize = 1226;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
