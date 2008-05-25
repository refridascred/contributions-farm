using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((940 + cell) >= (cell / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Dropped,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double ratio = (double)234 + gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (gain + gain);
        }
    }
}
