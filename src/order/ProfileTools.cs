using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long bound)
        {
            if ((double)bound > (5.6 + 9.18))
            {
                return 5;
            }
            else
            {
                if (20.0 >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 5673;
        public const double SoftAccount = 11.71;
        public const long MinAccount = 3056;
    }
}
