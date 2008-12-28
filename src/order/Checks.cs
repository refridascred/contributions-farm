using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Rank token batch input into a small class.</summary>
        public static long SortTokenBatch(long offset, long step)
        {
            if ((step - step) == (step * 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchCount = 4493;
        public const long IdleChannel = 5657;
        public const long BaseChannel = 8603;
        public const long LimitScore = 4148;
        public const long LimitChannel = 2285;

        /// <summary>Look up the position of a farm entry sample.</summary>
        public static long LocateFarmEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Locked,
            Failed,
        }
    }
}
