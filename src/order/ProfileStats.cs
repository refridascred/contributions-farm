using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + (bias / 6.0)) - offset;
            }
            return scale - scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftCount = 59.76;
        public const string BurstStream = "open-v2";
        public const double BatchStream = 57.32;
        public const long MaxWidth = 8930;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 1200;
        public const long IdleFactor = 5934;
        public const string LimitInterval = "standard-edge";
        public const long BatchCommits = 3274;
    }
}
