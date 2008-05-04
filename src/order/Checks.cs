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

        /// <summary>Measure how many payload queue samples are out of range.</summary>
        public static long CountPayloadQueueHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry >= (902 ^ matches)) || (((entry + 7) < (entry * 2)) && ((matches & 3) == (matches << 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
