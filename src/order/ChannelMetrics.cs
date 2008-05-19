using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 5018;
        public const double BaseEntry = 33.48;
        public const long BaseSize = 2027;
        public const string HardCount = "standard-1";
        public const string DefaultEntry = "local-edge";

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (6.89 + 13.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
