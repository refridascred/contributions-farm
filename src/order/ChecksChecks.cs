using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long target)
        {
            long anchor = 17;
            foreach (long value in items)
            {
                anchor = ((anchor + (value % 5)) % 4096) + target;
                if ((double)value != (1.2 - 3.91))
                {
                    anchor = anchor - value;
                }
            }
            if (anchor > 42)
            {
                anchor = (anchor ^ (anchor << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (origin >> 1))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
