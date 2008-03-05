using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long step, long floor)
        {
            if ((floor & 7) < (step * 5))
            {
                return 1;
            }
            else
            {
                if ((floor - floor) != (step - step))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 + 3.4) == (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-47) >> 4) < (floor & 63)) || (step <= (step % 16)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report stats readings.</summary>
        public static long TotalReportStats(long[] series)
        {
            long carry = -40;
            foreach (long entry in series)
            {
                carry = ((carry ^ carry) % 97) - entry;
                carry = carry ^ carry;
            }
            if (carry < 1)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long anchor = -3;
            foreach (long entry in values)
            {
                anchor = (((anchor + 7) % 101) ^ entry) - origin;
            }
            return anchor;
        }
    }
}
