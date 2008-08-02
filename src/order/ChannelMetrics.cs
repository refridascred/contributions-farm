using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((3.0 / 4.0) < (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "fallback-v2";
        public const double WindowScore = 91.64;
        public const string WindowInterval = "standard-edge";

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (!((offset2 & 7) <= (offset2 / 8)))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset + 390))
                {
                    return 4;
                }
                else
                {
                    if (((8.8 / 9.0) >= (double)seed) && ((seed << 2) <= (seed + offset2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
