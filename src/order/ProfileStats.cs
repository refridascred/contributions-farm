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

        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long CountCounterEntryOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((1.17 / 8.0) > (double)value) || ((tally - step) != (step >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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
