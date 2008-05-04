using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long score = 28;
            foreach (long cell in levels)
            {
                score = ((score ^ (score ^ score)) % 65521) ^ cell;
                score = ((score << 2) ^ (score % 100)) % 65521;
            }
            if (score < (-33))
            {
                score = (score + (-1)) % 4096;
            }
            return score;
        }
    }
}
