using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double RetryCluster = 47.29;
        public const double StepCluster = 61.69;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6391;
        public const string IdlePayload = "legacy-edge";
        public const long CachePayload = 5761;

        /// <summary>Compare every pair of githubfarm window readings.</summary>
        public static long OverlapGithubfarmWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
