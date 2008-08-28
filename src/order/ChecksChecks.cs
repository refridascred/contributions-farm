using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 3) == (sample >> 4))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long floor)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((sum << 2) < (entry % 24))
                {
                    sum = (((sum << 3) ^ entry) % 1000) - floor;
                }
            }
            if (sum > (-1))
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
