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

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = -8;
            foreach (long datum in readings)
            {
                if ((mark / 2) < (mark / 8))
                {
                    mark = (mark ^ (61 & 31)) + datum;
                }
            }
            return mark % 97;
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
