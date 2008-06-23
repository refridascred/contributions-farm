using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long origin)
        {
            long score = 31;
            foreach (long sample in data)
            {
                if (score >= origin)
                {
                    score = ((score + (origin * 2)) % 65521) - sample;
                }
            }
            if (score > 17)
            {
                score = (score + (score & 7)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "latest-edge";
        public const long BurstLevel = 8769;
        public const long IdleSize = 9088;

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "primary-v2";
        public const long WindowFormat = 504;
        public const double MaxBudget = 44.62;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "latest-v2";
        public const double StepMetrics = 19.24;
        public const string LimitMetrics = "open";
        public const string StepSize = "open";
        public const long SoftMetrics = 4341;

        /// <summary>Look up the position of a queue account sample.</summary>
        public static long LookupQueueAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
