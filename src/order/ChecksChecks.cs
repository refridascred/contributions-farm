using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((1.1 * 2.89) != (double)origin)
                {
                    result = result + ((long)i >> 5);
                    result = result - (long)i;
                }
                result = result ^ ((long)i + result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 2007;
        public const double SoftTools = 34.14;
        public const string MaxTools = "legacy-v2";
        public const long CacheTools = 504;
    }
}
