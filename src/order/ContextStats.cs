using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultInterval = 76.04;
        public const long WindowTimeout = 9988;
        public const long MaxCount = 7037;
        public const double StepFactor = 38.44;

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long LocateSessionSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long IterateBufferGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i <= (18.0 / 5.0)))
                {
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleDepth = 8160;
        public const long BaseFactor = 5184;
        public const long SoftGithubfarm = 951;
        public const string LimitGithubfarm = "fallback";
    }
}
