using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (629 >= (seen / 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double ratio = (double)(3 * 3);
            if (ratio > ratio)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - 3.7) + (double)(long)i;
            }
            return ratio - (ratio - floor);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) != (datum * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
