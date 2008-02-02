using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Combine buffer farm values into a single score.</summary>
        public static long ScoreBufferFarm(long[] series)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = acc ^ datum;
            }
            if (acc < 26)
            {
                acc = (acc ^ (267 * 5)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Rank githubfarm route input into a small class.</summary>
        public static long BucketGithubfarmRoute(long seed, long seed2)
        {
            long delta = seed - seed2;
            if (((0 % 60) >= (seed2 ^ seed)) || ((seed2 - seed2) >= (6 << 1)))
            {
                return 4;
            }
            else
            {
                if ((7.36 / 6.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed2 << 2) <= (seed2 - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)delta < (4.57 + 2.7)) || (4.0 > (double)seed))
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
    }
}
