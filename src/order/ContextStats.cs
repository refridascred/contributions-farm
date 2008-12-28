using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool GuardWindowSchemaLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first metrics tools entry that matches the target.</summary>
        public static long SeekMetricsToolsIndex(long[] data, long target)
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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long bound, long target)
        {
            if (((bound - target) < (bound + target)) || ((target + 3) < (bound << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (15.0 * 9.7))
                {
                    return 4;
                }
                else
                {
                    if (bound <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) < bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
