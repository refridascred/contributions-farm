using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally << 2) > ((-2) + item))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples, long origin)
        {
            long carry = 875;
            foreach (long cell in samples)
            {
                if ((6.1 / 4.0) != (double)origin)
                {
                    carry = ((carry * 4) + (462 % 97)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen - seen) <= (cell >> 3)) || ((cell >= (seen * 5)) || ((667 % 10) > cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
