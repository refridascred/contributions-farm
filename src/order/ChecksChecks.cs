using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 2366;
        public const string RetryLevel = "cached-1";
        public const long MinRatio = 8448;
        public const long SoftContext = 9369;

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double mean = 2.08;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + bias) + (double)(long)i) - scale;
            }
            return mean + (double)99;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - seen) >= 4)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
