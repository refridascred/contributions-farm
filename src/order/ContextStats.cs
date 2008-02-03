using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long limit, long origin)
        {
            if ((limit - 6) <= origin)
            {
                return 8;
            }
            else
            {
                if (origin <= (93 << 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) == (origin / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (limit + 18)) || ((limit - origin) < origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report githubfarm measurements.</summary>
        public static double ScaleReportGithubfarm(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - span) - (double)(long)i) - rate;
            }
            return weight + 7.26;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Grade a queue cluster value against two limits.</summary>
        public static long ClassifyQueueCluster(long bound, long limit)
        {
            long cur = bound - limit;
            if ((cur - limit) < (bound ^ limit))
            {
                return 4;
            }
            else
            {
                if (((6.0 - 7.94) == (double)bound) && ((cur + cur) <= bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit < (double)908)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
