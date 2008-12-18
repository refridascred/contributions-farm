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

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
