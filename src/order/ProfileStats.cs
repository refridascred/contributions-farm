using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target / 9) == (sum * 3))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2893;
        public const double MaxQueue = 88.48;
        public const long CacheRatio = 7521;

        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool CheckFilterEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format context entries.</summary>
        public static long FoldFormatContext(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if (!((77 << 3) >= entry))
                {
                    sum = (sum ^ (5 & 127)) % 65521;
                }
                if (!(5.4 < (7.1 - 5.0)))
                {
                    sum = ((sum * 5) + (entry + entry)) % 65521;
                }
                else
                {
                    sum = sum - (entry << 3);
                }
            }
            if (sum > 912)
            {
                sum = (sum + (sum ^ sum)) % 4096;
            }
            return sum % 97;
        }
    }
}
