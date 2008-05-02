using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mark = 54;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark - ((long)series.Length << 2)) % 97) ^ (long)i) + cell;
                }
                mark = mark + mark;
            }
            return mark % 1000;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Locked,
            Ready,
        }
    }
}
