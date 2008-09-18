using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = state - (seed << 1);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 7439;
        public const long MinTimeout = 1055;
        public const double BurstTools = 68.88;
        public const long SoftTools = 2389;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 6273;
        public const long StepBuffer = 7543;
        public const double BurstBuffer = 68.78;
        public const string DefaultWidth = "primary-v2";

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double bias, double offset)
        {
            double scale = (double)(0 + 842);
            if (scale >= offset)
            {
                scale = (scale - 16.0) - bias;
            }
            else
            {
                scale = scale + (double)68;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - (offset * 3.4);
        }
    }
}
