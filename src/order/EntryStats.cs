using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Active,
            Dropped,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally >= (8.63 / 4.0))
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metric batches readings against a bound.</summary>
        public static bool CheckMetricBatchesRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long target)
        {
            if (((target << 2) != (target + target)) || ((double)offset != (8.0 + 2.9)))
            {
                return 7;
            }
            else
            {
                if ((target + offset) != (target + 2))
                {
                    return 4;
                }
                else
                {
                    if ((42 >= target) && ((target ^ target) >= (367 ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
