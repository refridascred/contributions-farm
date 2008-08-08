using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
