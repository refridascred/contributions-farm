using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long floor)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if ((floor & 31) < floor)
                {
                    sum = (((sum * 4) + floor) % 255) + reading;
                }
                sum = (sum ^ (floor & 127)) % 255;
            }
            if (sum > 656)
            {
                sum = (sum * 4) + (floor >> 4);
            }
            return sum;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long floor)
        {
            long state = 74;
            foreach (long value in series)
            {
                if ((double)value < (0.19 - 12.0))
                {
                    continue;
                }
                state = state + state;
            }
            if (state > 2)
            {
                state = (state << 2) ^ (floor + state);
            }
            return state % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
