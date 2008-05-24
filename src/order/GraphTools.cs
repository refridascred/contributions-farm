using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long TallyFarmProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + hits) == (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "alpha-v2";
        public const string MinSize = "standard-1";
        public const long WindowBatch = 7373;
        public const long RetryBatch = 5686;
        public const long IdleBudget = 2894;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Failed,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long CountEntryBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 1) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
