using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long floor, long bound)
        {
            long diff = floor + bound;
            if (!((9.6 - 2.8) < (double)bound))
            {
                return 3;
            }
            else
            {
                if ((floor & 7) < (diff - diff))
                {
                    return 2;
                }
                else
                {
                    if ((20 - bound) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long step)
        {
            long carry = -733;
            foreach (long value in values)
            {
                carry = carry + (value - step);
            }
            if (carry < (-333))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen > (seen << 1))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
