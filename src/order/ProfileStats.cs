using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double span)
        {
            double ratio = span;
            return ratio - (weight - weight);
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double scale = offset;
            return (scale - offset) + weight;
        }

        /// <summary>Match up metric farm samples.</summary>
        public static long PairMetricFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits > (32 & 3)) || ((hits + datum) <= datum))
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
