using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0.11 - 1.3) != (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long step)
        {
            long total = 982;
            foreach (long value in values)
            {
                if ((double)value <= (19.0 + 0.3))
                {
                    total = (total - (total + total)) + step;
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double weight2 = (weight + span) + 1.4;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
