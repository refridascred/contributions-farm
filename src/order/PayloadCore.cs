using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long TallyMetricEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((-624) > seen))
                {
                    seen = ((seen + 2) ^ entry) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Pending,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long seed)
        {
            long cur = bound ^ seed;
            if ((seed % 16) <= cur)
            {
                return 3;
            }
            else
            {
                if (bound <= (cur - bound))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (cur + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound != (15.0 * 0.73))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
