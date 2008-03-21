using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Closed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 198;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 9)) % 4096;
            }
            return sum;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (bound + bound)) % 1000;
                long prev = (bound << 1) >> 4;
                anchor = (anchor * 4) + prev;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
