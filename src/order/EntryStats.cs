using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 4.57;
            if (mean < (5.2 - ratio))
            {
                mean = mean - (7.0 + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor - ratio);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheDepth = 6568;
        public const double CacheFactor = 16.5;
        public const string StepSpan = "fallback-edge";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "open";
        public const string MaxSpan = "legacy-v2";
        public const long WindowTimeout = 3378;
    }
}
