using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9892;
        public const long BurstCluster = 4113;
        public const long StepCluster = 4726;
        public const string RetrySize = "open-v2";

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long seed)
        {
            if (seed > (bound % 3))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (2.26 - 7.2)) || ((double)bound != (7.17 * 2.48)))
                {
                    return 2;
                }
                else
                {
                    if (((-101) + seed) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
