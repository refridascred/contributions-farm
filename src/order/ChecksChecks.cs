using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the filter format series from a seed.</summary>
        public static long StepFilterFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (long)i) % 97;
                anchor = (anchor ^ (target + target)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 55.93;
        public const long MaxTimeout = 4433;
        public const long CacheStats = 9954;
        public const long MinStats = 4068;
        public const long HardStats = 3328;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9660;
        public const long MinCount = 4806;
        public const string BurstWindow = "alpha-edge";
    }
}
