using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools notes counter forward.</summary>
        public static long RollToolsNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long origin)
        {
            long bound = target - origin;
            if ((bound & 31) == (origin / 3))
            {
                return 1;
            }
            else
            {
                if ((4.0 + 0.42) == (double)target)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
