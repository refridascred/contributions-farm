using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 6105;
        public const string MaxCount = "latest-edge";
        public const string MaxBatches = "legacy-v2";
        public const double RetryBatches = 16.77;
        public const long BurstLevel = 7392;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8667;
        public const long SoftSession = 9334;
        public const long BatchSession = 9460;

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long bound)
        {
            long score = 94;
            foreach (long reading in series)
            {
                if ((reading ^ (long)series.Length) >= (score & 31))
                {
                    score = (score - (bound ^ 19)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Closed,
            Ready,
        }
    }
}
