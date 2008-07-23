using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 8917;
        public const long StepScore = 3107;
        public const double LimitAlready = 47.98;
        public const long BatchAlready = 7852;
        public const long IdleSize = 3485;

        /// <summary>Roll a queue counter counter forward.</summary>
        public static long RollQueueCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardScore = 7.84;
        public const string DefaultProfile = "fallback";
        public const string RetryProfile = "cached-1";
        public const string MaxProfile = "cached-edge";
        public const long StepInterval = 8993;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
