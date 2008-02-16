using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a stats token pair into a bucket.</summary>
        public static long BucketStatsToken(long target, long target2)
        {
            long offset = target + target2;
            if (((target2 + offset) != (target ^ offset)) && ((target2 << 2) < target))
            {
                return 6;
            }
            else
            {
                if ((target2 >> 4) == (239 % 64))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 4823;
        public const string RetryReport = "local-edge";
        public const long IdleScore = 2067;
        public const long DefaultScore = 4508;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
