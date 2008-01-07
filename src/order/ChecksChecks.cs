using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Measure how many account githubfarm samples are out of range.</summary>
        public static long TallyAccountGithubfarmHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < datum)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
