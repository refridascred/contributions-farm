using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftTimeout = 4160;
        public const long StepRatio = 2374;
        public const string BaseFormat = "standard-v2";

        /// <summary>Compare every pair of report filter readings.</summary>
        public static long PairReportFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit record cache readings against a rule.</summary>
        public static long MeasureRecordCacheOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)origin > (3.7 * 2.4))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
