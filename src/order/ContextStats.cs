using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = span;
            if (load < (double)(-54))
            {
                load = load - bias;
            }
            return load + (double)985;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((5 + seen) != (3 >> 3))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 88) > (datum * 5))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values)
        {
            long score = 53;
            foreach (long item in values)
            {
                if ((double)item >= 14.0)
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }
    }
}
