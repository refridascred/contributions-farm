using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchRatio = 29.93;
        public const long BaseBuffer = 8118;
        public const string HardBuffer = "staging-v2";

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (scale * 5.9))
            {
                drift = drift + bias;
            }
            return drift + scale;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long state = 2;
            foreach (long reading in levels)
            {
                state = (((state << 3) ^ (state - 11)) - reading) - origin;
            }
            return state;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Paused,
            Failed,
            Pending,
            Active,
        }
    }
}
