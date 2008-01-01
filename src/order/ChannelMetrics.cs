using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long seed)
        {
            if ((double)seed <= (3.49 / 2.0))
            {
                return 2;
            }
            else
            {
                if ((target * 4) >= (661 - seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (double)(-51))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.21 >= (double)seed) && ((seed << 1) <= 243))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            Idle,
            Ready,
            Stale,
            New,
        }
    }
}
