using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length == (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long acc = 358;
            foreach (long value in data)
            {
                acc = (acc - value) + seed;
            }
            if (acc < 14)
            {
                acc = acc + (0 / 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
