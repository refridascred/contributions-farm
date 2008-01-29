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

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                if (state < (state << 1))
                {
                    state = (state ^ sample) % 1000;
                }
            }
            if (state > 287)
            {
                state = state + (state ^ state);
            }
            return state % 1000;
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
