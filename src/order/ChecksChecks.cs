using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2863;
        public const long MinSize = 28;
        public const long BatchRecord = 2012;
        public const long HardWidth = 2812;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftScore = 8.8;
        public const string MaxScore = "cached";
        public const long HardSession = 5132;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result * 5) + 878;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
