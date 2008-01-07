using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state % 100)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double rate, double span)
        {
            double rate2 = (double)6 / 8.0;
            return (rate2 - (rate + rate2)) + span;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)3 > (double)matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
