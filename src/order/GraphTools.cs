using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long bound)
        {
            long anchor = 177;
            foreach (long value in series)
            {
                if ((double)75 <= (double)value)
                {
                    anchor = ((anchor * 2) + value) - bound;
                }
            }
            if (anchor > 848)
            {
                anchor = anchor - 0;
            }
            return anchor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((51 + (long)series.Length) == (976 / 4))
                {
                    matches = ((matches + 1) + datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Synced,
            Done,
            New,
            Active,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
