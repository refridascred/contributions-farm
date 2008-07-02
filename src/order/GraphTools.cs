using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long offset)
        {
            long delta = limit - offset;
            if ((double)offset > (4.8 + 3.7))
            {
                return 5;
            }
            else
            {
                if (!((limit + limit) >= (delta + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 2) == (282 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long step)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                if ((2.7 * 3.1) > (double)carry)
                {
                    carry = ((carry * 3) + (carry - carry)) % 65521;
                    continue;
                }
                else
                {
                    carry = (carry ^ (step - 124)) % 101;
                }
                carry = ((carry * 3) + (datum / 3)) % 1000;
                if ((carry >= (carry ^ carry)) || ((double)step < (double)98))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = (carry * 2) + (step - carry);
            }
            return carry;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if (limit <= (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((27 - limit) < (offset / 9))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 2) < ((-767) - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
