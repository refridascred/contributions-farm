using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((target ^ datum) < (target / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long AuditClusterBatchGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6 ^ hits) >= (hits & 7))
                {
                    hits = ((hits + 1) + datum) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift < drift)
            {
                drift = (drift - drift) + bias;
            }
            return drift + (double)3;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + 9) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
