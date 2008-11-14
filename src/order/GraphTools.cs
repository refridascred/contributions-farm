using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSpan = 1.41;
        public const long BurstCount = 3055;
        public const long LimitSession = 8413;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Ready,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long floor)
        {
            long gap = origin + floor;
            if ((8.12 * 5.0) < (double)gap)
            {
                return 7;
            }
            else
            {
                if (((floor >> 2) >= (gap & 31)) || ((double)gap >= 6.68))
                {
                    return 6;
                }
                else
                {
                    if (((origin - floor) < gap) && ((floor + origin) != (origin / 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((0.88 * 2.0) > (double)gap) && ((-4) < (floor << 3)))
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
        }
    }
}
