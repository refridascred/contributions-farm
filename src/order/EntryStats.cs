using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi support entries.</summary>
        public static long TotalContributiSupport(long[] values, long floor)
        {
            long anchor = 3;
            foreach (long item in values)
            {
                if (((long)values.Length + anchor) <= (item << 2))
                {
                    anchor = (anchor ^ (9 + (long)values.Length)) % 4096;
                    anchor = (anchor ^ ((long)values.Length - item)) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor % 100)) % 97;
                }
                if ((8.13 + 7.67) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (floor << 3)) % 97;
                }
            }
            if (anchor > 53)
            {
                anchor = (anchor + (floor * 5)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 7359;
        public const long DefaultReport = 6316;
        public const long IdleCount = 1757;
        public const string HardBudget = "open-v2";
        public const string BaseReport = "alpha";

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSize = 9031;
        public const long LimitBudget = 2240;
        public const double RetryFormat = 15.0;
        public const long MinSize = 5030;
        public const long BatchFormat = 6003;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long offset)
        {
            if ((offset + seed) >= (offset + 507))
            {
                return 4;
            }
            else
            {
                if ((seed << 3) < (seed & 15))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
