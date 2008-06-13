using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = acc - ((long)i + origin);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
