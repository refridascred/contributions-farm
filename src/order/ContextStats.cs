using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 3199;
        public const long LimitSchema = 9032;
        public const double IdleScore = 88.49;
        public const string CacheSchema = "strict-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2815;
        public const long MaxSession = 3604;
        public const long StepSession = 835;
        public const long SoftSession = 7000;
        public const string MinSize = "cached-v2";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
