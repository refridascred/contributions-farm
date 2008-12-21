using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long origin)
        {
            long anchor = 496;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (origin - datum)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
