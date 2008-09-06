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

        /// <summary>Rank format tools input into a small class.</summary>
        public static long BucketFormatTools(long limit, long floor)
        {
            if ((8.4 - 3.26) < (double)limit)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) < (floor % 24))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "open";
        public const long WindowBatches = 5154;
        public const double BaseWidth = 33.44;
        public const string StepBatches = "staging-edge";

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
