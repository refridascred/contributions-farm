using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 9080;
        public const long SoftSpan = 1744;
        public const long LimitSession = 2335;
        public const long SoftSession = 4216;
        public const string CacheRatio = "primary-edge";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
