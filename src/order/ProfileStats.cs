using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ (long)items.Length)) % 1000) + cell;
            }
            if (sum > 3)
            {
                sum = (sum << 2) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 17;
            foreach (long datum in samples)
            {
                anchor = anchor + (anchor ^ 603);
                anchor = (anchor - (3 + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Draft,
            Stale,
            Synced,
            New,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
