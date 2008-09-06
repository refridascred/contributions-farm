using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Active,
            Pending,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSize = 37.9;
        public const string MinRatio = "primary";
        public const double CacheInterval = 28.77;
        public const long CacheEditor = 3118;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long limit2)
        {
            if ((double)limit2 == (16.0 * 3.94))
            {
                return 7;
            }
            else
            {
                if (6.8 <= (double)limit2)
                {
                    return 4;
                }
                else
                {
                    if ((269 + limit) <= limit2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Draft,
            Failed,
            New,
            Idle,
        }
    }
}
