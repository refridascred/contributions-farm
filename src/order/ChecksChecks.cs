using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((4 * 5) >= (seen >> 1)) || (((-31) - floor) > seen)) && ((double)floor >= (4.43 + 2.4)))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long MeasureFilterContributiOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen <= (5.2 + 0.1))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
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
