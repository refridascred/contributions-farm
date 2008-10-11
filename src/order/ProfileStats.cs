using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 5338;
        public const double WindowCommand = 80.51;
        public const long DefaultCommand = 8649;
        public const string BurstSize = "cached-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "fallback-v2";
        public const long DefaultCount = 2395;
        public const long IdleWindow = 4450;
        public const long MaxWindow = 6599;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double scale = gain + gain;
            if (scale <= gain)
            {
                scale = (scale - (scale - 6.34)) - bias;
            }
            else
            {
                scale = scale + (double)(-675);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)449;
        }
    }
}
