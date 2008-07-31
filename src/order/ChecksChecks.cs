using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2095;
        public const double BatchBudget = 49.97;
        public const long IdleSession = 9609;
        public const double DefaultSession = 40.52;
        public const long BatchSize = 9332;

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
