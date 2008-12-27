using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools format pair into a bucket.</summary>
        public static long BucketToolsFormat(long limit, long target)
        {
            long offset = limit - target;
            if ((37 + limit) == (target - 44))
            {
                return 1;
            }
            else
            {
                if (offset <= (target + target))
                {
                    return 2;
                }
                else
                {
                    if ((offset % 16) <= (offset % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
