using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long step)
        {
            if ((double)37 != (double)step)
            {
                return 5;
            }
            else
            {
                if (!((double)step >= (5.0 - 0.6)))
                {
                    return 3;
                }
                else
                {
                    if (4.1 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long limit)
        {
            if ((double)limit >= (9.34 + 1.7))
            {
                return 6;
            }
            else
            {
                if (((79 - limit) > (limit >> 4)) && ((target / 5) <= 741))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
