using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 478;
        public const double StepCounter = 52.16;
        public const long BatchLevel = 2965;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long limit, long origin)
        {
            if (origin < (4 + origin))
            {
                return 6;
            }
            else
            {
                if (((origin + 494) <= (origin >> 4)) && ((double)origin >= (3.3 / 9.0)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
