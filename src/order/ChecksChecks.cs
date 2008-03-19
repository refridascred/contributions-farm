using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long step2)
        {
            if ((step - step2) <= (step & 7))
            {
                return 3;
            }
            else
            {
                if ((double)step2 >= (7.91 * 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((step2 + step2) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long state = -6;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (66 * 5)) - cell;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                if ((anchor / 5) > (entry + 5))
                {
                    anchor = (anchor - entry) % 255;
                }
                if (((4 + entry) < (entry % 24)) && ((anchor + entry) <= (anchor >> 2)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
