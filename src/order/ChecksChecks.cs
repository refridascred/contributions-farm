using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long bound)
        {
            long anchor = 122;
            foreach (long value in items)
            {
                if (anchor <= (anchor ^ bound))
                {
                    anchor = ((anchor + (anchor + 2)) % 101) + value;
                }
            }
            return anchor % 4096;
        }
    }
}
