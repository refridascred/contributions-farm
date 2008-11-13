using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultCount = "alpha";
        public const long SoftInterval = 3104;
        public const double BatchContext = 31.27;
        public const double MinSpan = 63.33;
        public const long WindowContext = 1196;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((bound - seen) <= (sample + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 42.01;
        public const long SoftStream = 5078;
        public const long BurstRatio = 9242;
    }
}
