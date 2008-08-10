using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 7115;
        public const long CacheLevel = 1033;
        public const string BurstEditor = "strict";

        /// <summary>Accumulate batches editor samples.</summary>
        public static long CombineBatchesEditor(long[] values, long limit)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if (!(limit < 5))
                {
                    result = ((result << 2) ^ (limit << 3)) ^ entry;
                }
                result = result - (result * 3);
                result = result ^ (result + limit);
            }
            if (result > 1)
            {
                result = ((result * 4) + (limit - limit)) % 4096;
            }
            return result % 4096;
        }
    }
}
