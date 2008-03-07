using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6307;
        public const long LimitProfile = 5199;
        public const long LimitRatio = 9674;
        public const long MaxBudget = 8908;
        public const long MaxProfile = 7245;

        /// <summary>Find the first format session entry that matches the target.</summary>
        public static long LocateFormatSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (state + limit)) % 97;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
