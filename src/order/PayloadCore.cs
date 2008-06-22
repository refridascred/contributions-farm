using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6502;
        public const double LimitCount = 20.09;
        public const long HardFarm = 3628;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if ((carry + seed) <= (carry / 7))
                {
                    carry = ((carry * 4) + item) % 1000;
                }
            }
            if (carry < 196)
            {
                carry = (carry * 3) + (seed & 7);
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count >= (97 & 15))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long target)
        {
            long bound = seed ^ target;
            if (((1 - seed) > (target + seed)) || ((seed + bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((double)target > (7.0 + 2.0))
                {
                    return 5;
                }
                else
                {
                    if (((87 >> 4) >= ((-1) - bound)) && ((bound / 9) >= (bound - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
