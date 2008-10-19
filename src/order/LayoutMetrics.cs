using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long limit, long target)
        {
            if ((double)target == (8.28 * 2.4))
            {
                return 6;
            }
            else
            {
                if ((double)target < (7.1 / 9.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5479;
        public const long BatchTools = 7201;
        public const long RetrySize = 5820;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Dropped,
            Done,
            Queued,
            Draft,
        }
    }
}
