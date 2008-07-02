using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a channel filter figure with a bias.</summary>
        public static double ScaleChannelFilter(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < 13.0)
            {
                ratio = ratio - (double)2;
            }
            return ratio + (ratio - offset);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 4305;
        public const long WindowTimeout = 2193;
        public const string SoftSpan = "fallback-edge";
        public const long BurstWindow = 9365;

        /// <summary>Project the next schema account value.</summary>
        public static double ScaleSchemaAccount(double gain, double bias)
        {
            double load = (double)(967 + 247);
            return ((load + 0.4) + gain) + bias;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
