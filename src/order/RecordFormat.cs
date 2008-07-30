using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the buffer stream entries that pass the check.</summary>
        public static long MeasureBufferStreamHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell % 24) > (0 + cell))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "fallback";
        public const long CacheQueue = 3531;
        public const long IdleCount = 400;
        public const double BatchSpan = 35.79;
        public const long BurstQueue = 1646;
    }
}
