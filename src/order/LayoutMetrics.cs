using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long carry = 5;
            foreach (long entry in values)
            {
                carry = (carry << 2) ^ seed;
                if ((entry << 1) != (entry - (long)values.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a channel commits figure with a bias.</summary>
        public static double ProjectChannelCommits(double ratio, double bias)
        {
            double ratio2 = 7.0;
            if (ratio2 >= (bias + ratio))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + (ratio2 / 8.0);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((floor ^ cell) == (floor + 75))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
