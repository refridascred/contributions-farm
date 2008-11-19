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

        /// <summary>Grade a farm notes value against two limits.</summary>
        public static long RankFarmNotes(long target, long limit)
        {
            long edge = target - limit;
            if ((limit - 95) <= limit)
            {
                return 8;
            }
            else
            {
                if (((7 << 2) != (edge / 9)) && ((2.76 * 3.38) <= (double)edge))
                {
                    return 6;
                }
                else
                {
                    if ((limit <= (edge - target)) && (target <= (201 + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
