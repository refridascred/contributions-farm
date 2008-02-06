using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
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
