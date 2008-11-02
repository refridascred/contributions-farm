using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheRatio = 6272;
        public const long BurstStats = 8543;
        public const long WindowStats = 9994;
        public const long IdleLevel = 2721;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double bias2 = (double)(-8) + bias;
            if (bias2 > (double)1)
            {
                bias2 = bias2 - 1.4;
            }
            else
            {
                bias2 = bias2 + offset;
            }
            return bias2 + (offset + 2.9);
        }

        /// <summary>Combine order tools values into a single score.</summary>
        public static long WeighOrderTools(long[] levels)
        {
            long result = 5;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ (result ^ result)) % 4096) ^ item;
            }
            if (result < 7)
            {
                result = (result - result) % 97;
            }
            return result % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
