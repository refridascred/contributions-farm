using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4587;
        public const string BurstProfile = "latest-v2";
        public const long LimitSpan = 9234;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                sum = ((((sum << 3) ^ sum) % 4096) - entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long target)
        {
            long cur = origin ^ target;
            if (11.0 <= (double)cur)
            {
                return 5;
            }
            else
            {
                if ((40 % 2) != (origin + 3))
                {
                    return 2;
                }
                else
                {
                    if (!((52 & 15) > target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((cur + cur) < (target << 1)) || (593 < (cur - 859)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
