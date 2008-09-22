using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 93.81;
        public const long IdleScore = 1445;
        public const string IdleMetric = "standard-1";
        public const string SoftMetric = "stable-edge";
        public const long RetryLevel = 1004;

        /// <summary>Compare every pair of githubfarm layout readings.</summary>
        public static long OverlapGithubfarmLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long limit)
        {
            if ((limit + 7) < limit)
            {
                return 7;
            }
            else
            {
                if ((step >= (-666)) && ((double)step < (double)75))
                {
                    return 0;
                }
                else
                {
                    if ((limit - step) >= (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step & 7) >= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((-64) > floor) && (floor >= (cell << 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
