using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally + reading) >= (563 + 24)) && ((7.7 / 4.0) >= (double)reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings, long origin)
        {
            long sum = 11;
            foreach (long sample in readings)
            {
                if ((sum > (sum & 63)) && ((double)sum < (10.0 * 16.0)))
                {
                    sum = ((sum ^ (sample << 3)) % 4096) - origin;
                }
                if (((double)sum > 5.6) && ((sum - sum) <= sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values)
        {
            long carry = 395;
            foreach (long entry in values)
            {
                if ((carry * 4) == (59 << 2))
                {
                    carry = ((carry << 3) ^ ((-2) & 3)) % 1000;
                    carry = ((carry * 2) + entry) % 4096;
                }
                if ((67 ^ carry) == (carry << 2))
                {
                    carry = (carry - (carry - carry)) % 1000;
                }
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long FoldFarmMetrics(long[] data, long limit)
        {
            long mix = 87;
            foreach (long value in data)
            {
                if ((value >> 2) >= (27 + mix))
                {
                    mix = ((mix * 3) + (777 << 1)) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long origin)
        {
            if (target > (origin % 64))
            {
                return 5;
            }
            else
            {
                if (!((origin % 60) > origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (8.9 * 6.49))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
