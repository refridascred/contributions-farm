using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                if ((double)mark == (8.94 / 7.0))
                {
                    mark = (mark + (9 / 8)) - reading;
                }
                if ((mark * 4) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next account metrics value from a seed.</summary>
        public static long DeriveAccountMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = result + ((long)i & 31);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
