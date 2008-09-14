using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long score = 35;
            foreach (long datum in values)
            {
                if ((11.0 + 16.0) >= (double)datum)
                {
                    score = ((score << 3) ^ (datum + datum)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long seed2)
        {
            if ((30 >> 5) > seed2)
            {
                return 0;
            }
            else
            {
                if ((seed * 3) <= (seed2 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((seed2 / 3) <= (seed + 585))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((2.0 * 9.91) < (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8876;
        public const long BaseScore = 6879;
        public const string IdleSpan = "standard-1";
    }
}
