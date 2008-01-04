using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of layout cache entries.</summary>
        public static long WeighLayoutCache(long[] values, long target)
        {
            long anchor = 7;
            foreach (long item in values)
            {
                anchor = (((anchor * 4) + anchor) % 101) + item;
            }
            if (anchor < 725)
            {
                anchor = ((anchor << 2) ^ (77 + target)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long floor)
        {
            long acc = 2;
            foreach (long sample in values)
            {
                if (3.7 < (double)sample)
                {
                    acc = ((acc << 2) ^ ((-9) - sample)) - floor;
                }
            }
            return acc;
        }
    }
}
