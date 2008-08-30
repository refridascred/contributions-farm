using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long step)
        {
            long step2 = bound - step;
            if ((step2 - step2) >= (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if (!((double)step2 > (4.2 * 1.0)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 >= step) && (step < (bound >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "legacy";
        public const string LimitTimeout = "stable-1";
        public const long LimitRoute = 9737;
        public const double IdleRoute = 49.21;
        public const string SoftRoute = "legacy-v2";
    }
}
