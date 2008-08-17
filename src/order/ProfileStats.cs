using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((14 - reading) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6950;
        public const long DefaultProfile = 7271;
        public const long IdleCount = 3293;
        public const long DefaultLevel = 8272;

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)state != (16.0 - 0.2)))
                {
                    state = (state - (long)i) % 97;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
