using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a stats batches reading by value.</summary>
        public static long LookupStatsBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm metrics readings against a rule.</summary>
        public static long MeasureGithubfarmMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
