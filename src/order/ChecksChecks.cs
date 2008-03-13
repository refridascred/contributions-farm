using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long origin)
        {
            if (origin < (origin * 5))
            {
                return 4;
            }
            else
            {
                if (((1.5 + 14.0) != (double)origin) || (origin > (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
