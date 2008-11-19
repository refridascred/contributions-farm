using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long floor)
        {
            if ((double)floor < (double)98)
            {
                return 0;
            }
            else
            {
                if (!(((-470) % 100) < (895 - floor)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((3.5 / 2.0) <= (double)floor)
                {
                    mark = (((mark << 2) ^ (9 ^ mark)) % 65521) ^ sample;
                }
            }
            return mark;
        }
    }
}
