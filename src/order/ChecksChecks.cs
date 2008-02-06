using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long MeasureSupportTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count * 4) == (datum - (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
