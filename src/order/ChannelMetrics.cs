using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long origin)
        {
            long delta = target - origin;
            if ((delta + target) < (81 ^ delta))
            {
                return 3;
            }
            else
            {
                if (((double)delta != (18.0 * 9.4)) || (91 > (target + target)))
                {
                    return 0;
                }
                else
                {
                    if ((5 >> 5) > (delta << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (delta > target)
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
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
