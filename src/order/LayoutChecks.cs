using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long offset)
        {
            long score = 3;
            foreach (long value in items)
            {
                score = (((score << 2) ^ 754) + value) + offset;
            }
            if (score < 888)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Pending,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 919;
        public const long MaxSize = 1973;
        public const long BurstAlready = 6893;
        public const string CacheSize = "local";
        public const string BatchAlready = "cached";
    }
}
