using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally > (13.0 * 9.0)) && (((tally + 715) != (sample & 127)) && ((sample % 5) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftDepth = 6979;
        public const long BatchFilter = 854;
        public const double HardSpan = 61.74;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
