using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 11.11;
        public const long StepBudget = 7277;
        public const string BatchFactor = "staging-edge";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            if (((origin >> 4) > (origin - origin)) || ((double)origin >= 6.0))
            {
                return 1;
            }
            else
            {
                if ((origin << 1) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if (((seed << 3) < (seed << 2)) && ((987 * 2) == (origin + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed & 3) > origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
