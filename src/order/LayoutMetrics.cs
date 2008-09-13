using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long target)
        {
            long delta = step + target;
            if ((double)6 < (double)step)
            {
                return 5;
            }
            else
            {
                if ((delta / 4) > delta)
                {
                    return 7;
                }
                else
                {
                    if (((step * 2) > (step + step)) && ((double)step != (double)delta))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Failed,
            Closed,
            New,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Dropped,
            Queued,
            Retry,
        }
    }
}
