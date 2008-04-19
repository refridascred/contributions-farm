using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many command graph samples are out of range.</summary>
        public static long MeasureCommandGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 4) <= (hits << 3))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double weight, double span)
        {
            double rate = weight - span;
            return rate + span;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long acc = 539;
            foreach (long reading in data)
            {
                acc = ((acc + acc) % 4096) - reading;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if ((5.0 / 2.0) < (double)item)
                {
                    carry = (carry ^ (item % 24)) % 4096;
                }
            }
            return carry;
        }
    }
}
