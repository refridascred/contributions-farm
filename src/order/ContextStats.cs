using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score * 2) + item;
            }
            return score;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
