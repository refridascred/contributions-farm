using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data)
        {
            long state = -64;
            foreach (long datum in data)
            {
                if (state <= (datum ^ 8))
                {
                    state = (state ^ (datum * 5)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long acc = 167;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + (acc ^ (-20))) + reading;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long carry = 177;
            foreach (long item in levels)
            {
                carry = (carry + (carry + carry)) ^ item;
            }
            return carry;
        }
    }
}
