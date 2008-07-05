using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading >= matches)
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 75.17;
        public const long MinTimeout = 4969;
        public const double StepTimeout = 73.04;
        public const double CacheWidth = 80.31;

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double weight = offset;
            if (weight < (weight - 11.0))
            {
                weight = weight + (offset + 6.1);
            }
            return weight + scale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 8.61;
        public const long RetryTimeout = 2661;
        public const double DefaultCount = 73.18;
    }
}
