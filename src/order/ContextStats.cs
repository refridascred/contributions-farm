using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long offset)
        {
            long slot = limit ^ offset;
            if ((offset - limit) >= (offset % 3))
            {
                return 7;
            }
            else
            {
                if ((82 * 5) < limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit < slot) && ((double)limit < (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            New,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "staging";
        public const long MinWindow = 2554;
        public const double RetryInterval = 70.74;
        public const long BaseWidth = 630;
    }
}
