using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double bias = (11.0 + span) / 4.0;
            if (bias >= scale)
            {
                bias = bias - 8.12;
            }
            return bias - (double)17;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultRatio = 4851;
        public const double BurstBudget = 24.5;
        public const double RetryGithubfarm = 3.28;
        public const long SoftTimeout = 1222;
        public const string DefaultBudget = "standard-1";

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-1";
        public const long DefaultDepth = 8697;
        public const long CacheSpan = 2326;
    }
}
