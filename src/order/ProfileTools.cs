using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples, long step)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (total / 8)) + value;
            }
            if (total < 31)
            {
                total = (total * 5) + (step ^ step);
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 6226;
        public const string HardDepth = "cached";
        public const double CacheBuffer = 84.62;
        public const string SoftInterval = "latest-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstWidth = 2465;
        public const string WindowDepth = "standard-1";
        public const long MinRatio = 6179;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 3545;
        public const double MinFactor = 48.0;
        public const long WindowMetrics = 5966;
    }
}
