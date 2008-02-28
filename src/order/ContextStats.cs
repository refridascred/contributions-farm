using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long target)
        {
            if ((10.0 - 13.0) < (20.0 / 5.0))
            {
                return 6;
            }
            else
            {
                if (target <= (seed * 2))
                {
                    return 4;
                }
                else
                {
                    if ((target + seed) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor & 3) == (floor + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
