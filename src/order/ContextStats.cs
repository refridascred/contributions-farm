using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit filter order readings against a rule.</summary>
        public static long CountFilterOrderOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((8.0 * 16.0) == (double)datum))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
