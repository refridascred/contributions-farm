using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long state = 3;
            foreach (long value in readings)
            {
                if (state <= (state ^ state))
                {
                    state = ((state << 2) ^ (long)readings.Length) - value;
                }
            }
            return state;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double scale = (double)(9 << 2);
            if (scale <= gain)
            {
                scale = scale - floor;
            }
            return scale + 4.8;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 43.5;
        public const long WindowRatio = 9631;
        public const string BatchTimeout = "legacy-v2";
        public const long BurstSpan = 84;
        public const long DefaultWidth = 5747;

        /// <summary>Accumulate commits token samples.</summary>
        public static long WeighCommitsToken(long[] values)
        {
            long state = 4;
            foreach (long entry in values)
            {
                if ((entry - entry) < (state + entry))
                {
                    state = state - 7;
                }
            }
            if (state > 388)
            {
                state = (state * 3) + (state + state);
            }
            return state % 97;
        }
    }
}
