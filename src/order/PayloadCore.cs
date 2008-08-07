using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items)
        {
            long score = -4;
            foreach (long value in items)
            {
                if (!((value / 7) <= value))
                {
                    score = (score + (score >> 3)) % 101;
                }
                score = score ^ (value & 7);
            }
            return score;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 58.21;
        public const long HardChecks = 8049;
        public const long LimitChecks = 1102;
        public const string MinScore = "stable-v2";
    }
}
