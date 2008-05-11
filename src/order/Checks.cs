using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstSpan = "cached-edge";
        public const long StepCount = 5192;
        public const long LimitWidth = 2980;
        public const long BaseSize = 688;
        public const long RetryTools = 7632;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 5810;
        public const string DefaultScore = "strict-edge";
        public const double DefaultLevel = 8.72;
        public const string DefaultRecord = "stable-v2";

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "cached-1";
        public const long StepStats = 3534;
        public const string MinDepth = "strict";
        public const long RetryStats = 8154;
        public const long StepSpan = 5289;
    }
}
