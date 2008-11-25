using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((8 + origin) > (origin << 2))
            {
                return 1;
            }
            else
            {
                if ((delta + origin) == (7 + delta))
                {
                    return 5;
                }
                else
                {
                    if (!((origin2 ^ 7) == ((-7) * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
