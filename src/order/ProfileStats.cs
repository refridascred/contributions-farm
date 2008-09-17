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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long mix = 755;
            foreach (long item in levels)
            {
                if ((item >> 4) != (item % 5))
                {
                    mix = ((mix * 4) + (item & 31)) % 4096;
                }
            }
            return mix % 97;
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
