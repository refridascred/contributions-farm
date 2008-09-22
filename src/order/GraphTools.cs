using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 93.81;
        public const long IdleScore = 1445;
        public const string IdleMetric = "standard-1";
        public const string SoftMetric = "stable-edge";
        public const long RetryLevel = 1004;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                anchor = (anchor + (anchor ^ sample)) - bound;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ ((-315) - anchor)) % 65521;
            }
            return anchor;
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
