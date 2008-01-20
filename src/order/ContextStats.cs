using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] data, long target)
        {
            long score = 5;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (((score << 2) ^ (reading >> 2)) - (long)i) - target;
                    score = (score << 3) ^ (8 / 4);
                }
                if (!(17.0 < (double)score))
                {
                    score = (score * 4) + (score << 1);
                }
            }
            return score;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Queued,
        }
    }
}
