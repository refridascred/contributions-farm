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

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long state = 25;
            foreach (long sample in series)
            {
                if (state >= sample)
                {
                    state = (state * 4) + state;
                }
            }
            return state % 1000;
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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long target)
        {
            if ((double)target <= (6.0 - 2.7))
            {
                return 6;
            }
            else
            {
                if ((target & 7) > (target + origin))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 * 2.0) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
