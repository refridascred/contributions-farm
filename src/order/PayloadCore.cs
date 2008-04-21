using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleSize = "stable-1";
        public const string DefaultLevel = "legacy";
        public const long MinChannel = 9230;
        public const long HardChannel = 1333;
        public const long RetryBudget = 281;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            if (((double)seed < (5.8 + 7.5)) || ((seed - seed) <= (seed << 2)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 1) == (offset / 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long state = 420;
            foreach (long sample in series)
            {
                if ((target << 2) > (target / 6))
                {
                    state = ((state + (state / 2)) % 97) ^ sample;
                }
                if (target >= state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
