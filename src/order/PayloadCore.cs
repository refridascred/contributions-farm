using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 9932;
        public const long BurstBuffer = 100;
        public const long StepScore = 5605;
        public const string HardSize = "cached-v2";
        public const long RetryBuffer = 2993;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long limit)
        {
            if (((floor + limit) != (limit + 7)) && (limit > floor))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (7.0 + 6.7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
