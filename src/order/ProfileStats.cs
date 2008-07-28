using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long MeasureRecordStatsMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((step - 4) != (365 * 5))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }
    }
}
