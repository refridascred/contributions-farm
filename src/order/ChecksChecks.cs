using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count != (20.0 * 4.22))
                {
                    count = ((count + 3) + reading) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order report samples.</summary>
        public static long CombineOrderReport(long[] series)
        {
            long carry = 54;
            foreach (long datum in series)
            {
                if ((3.34 - 10.0) != (double)datum)
                {
                    carry = (carry - (carry << 2)) % 97;
                }
            }
            return carry % 65521;
        }
    }
}
