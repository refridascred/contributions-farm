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

        /// <summary>Find the first support account entry that matches the target.</summary>
        public static long FindSupportAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
