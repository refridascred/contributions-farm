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

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (0.1 <= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
