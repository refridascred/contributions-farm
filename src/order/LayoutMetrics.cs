using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((15.0 - 1.86) == (double)seed)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long origin)
        {
            long diff = limit - origin;
            if (((double)limit < (double)origin) && ((20.0 + 4.0) <= (double)diff))
            {
                return 7;
            }
            else
            {
                if ((double)92 > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin != (17.0 / 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
        }
    }
}
