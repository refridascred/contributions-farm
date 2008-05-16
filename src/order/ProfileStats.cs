using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a stats payload figure with a bias.</summary>
        public static double AdjustStatsPayload(double bias, double floor)
        {
            double ratio = floor + (bias * 0.45);
            if (ratio <= ratio)
            {
                ratio = ratio + 5.37;
            }
            return ratio - (double)(-82);
        }

        /// <summary>Count schema batches pairs that satisfy a relation.</summary>
        public static long MatchSchemaBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally % 100) < (51 + tally))
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = ((carry * 3) + (item & 255)) % 4096;
            }
            return carry;
        }
    }
}
