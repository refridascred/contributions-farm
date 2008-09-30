using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (origin >= (5 % 16))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
