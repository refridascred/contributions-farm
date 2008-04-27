using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit graph counter readings against a rule.</summary>
        public static long CountGraphCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((3.61 + 9.0) < (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + tally) == (tally << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + (step & 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
