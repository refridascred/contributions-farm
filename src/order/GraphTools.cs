using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
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
