using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long IterateCommitsStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state ^ origin) ^ (long)i2;
                }
                if ((state ^ state) > (origin ^ state))
                {
                    state = state + (origin / 4);
                }
                else
                {
                    state = ((state * 3) + (state ^ origin)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 3313;
        public const long StepOrder = 6054;
        public const string WindowOrder = "strict-edge";
        public const string MaxCount = "primary-v2";
        public const string BaseOrder = "alpha-1";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)target >= (10.0 * 0.4))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5259;
        public const string LimitTimeout = "standard-v2";
        public const double BatchFactor = 82.4;
        public const double IdleEntry = 65.04;
    }
}
