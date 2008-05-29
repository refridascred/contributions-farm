using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Done,
            Ready,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((target - 86) < hits) || ((3.6 * 3.54) >= (double)hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
