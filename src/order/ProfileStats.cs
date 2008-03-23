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

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long offset)
        {
            long total = 54;
            foreach (long item in items)
            {
                total = ((total + (total - total)) - item) - offset;
            }
            return total % 1000;
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
