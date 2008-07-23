using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a command queue pair into a bucket.</summary>
        public static long BucketCommandQueue(long floor, long floor2)
        {
            if ((floor2 & 127) >= floor2)
            {
                return 3;
            }
            else
            {
                if (((floor & 255) < floor2) || ((6.57 - 1.92) <= (double)floor2))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 8) > floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor2 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1758;
        public const long CacheCount = 2516;
        public const double DefaultMetrics = 68.18;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
