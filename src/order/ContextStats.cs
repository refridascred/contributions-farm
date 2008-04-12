using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (509 - target);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long origin)
        {
            if (!((double)origin != (9.0 * 2.84)))
            {
                return 5;
            }
            else
            {
                if (((double)origin > (12.0 - 5.9)) && ((seed + origin) <= seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
