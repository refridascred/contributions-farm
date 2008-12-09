using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally >> 4) < tally)
                {
                    tally = ((tally + 1) + reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((offset2 * 3) == (offset2 + offset))
            {
                return 6;
            }
            else
            {
                if ((offset2 * 5) != (2 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 2) == (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two schema batch measurements.</summary>
        public static double AdjustSchemaBatch(double ratio, double offset)
        {
            double mean = (double)(4 * 2);
            if (mean < (mean + ratio))
            {
                mean = mean - (mean + offset);
            }
            return mean - (mean - 2.0);
        }
    }
}
