using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)bound >= 7.8)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
