using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long bound)
        {
            long prev = limit + bound;
            if ((limit + limit) <= prev)
            {
                return 3;
            }
            else
            {
                if ((limit / 5) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
