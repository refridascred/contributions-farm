using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long limit)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                if (((double)limit < (double)carry) || ((limit + cell) == (cell - 18)))
                {
                    carry = (carry + cell) % 255;
                }
                if ((limit / 7) >= ((-352) >> 1))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
