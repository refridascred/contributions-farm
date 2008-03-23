using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSize = 85.07;
        public const string BatchAccount = "cached";
        public const long WindowAccount = 8559;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = 685;
            foreach (long entry in samples)
            {
                if (((result % 10) <= entry) || ((double)entry > (5.71 / 7.0)))
                {
                    result = result - (46 ^ entry);
                    result = (result - entry) % 101;
                }
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double bias2 = 1.94;
            return ((bias2 + bias2) + gain) + bias;
        }
    }
}
