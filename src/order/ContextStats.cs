using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings, long seed)
        {
            long state = 4;
            foreach (long item in readings)
            {
                state = ((state * 4) + item) % 255;
                if ((double)seed <= (18.0 - 10.0))
                {
                    state = ((state * 4) + (seed ^ (long)readings.Length)) % 97;
                }
            }
            if (state > 883)
            {
                state = (state + (seed / 7)) % 255;
            }
            return state % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultRatio = 65.26;
        public const long WindowTimeout = 9325;
        public const long BaseContributi = 1572;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long bound)
        {
            if (!((13.0 * 8.5) < (double)limit))
            {
                return 1;
            }
            else
            {
                if ((limit - limit) >= (bound << 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
