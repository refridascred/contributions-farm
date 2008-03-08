using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = (state + (state / 8)) + datum;
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] levels)
        {
            long score = 975;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (cell + cell))
                {
                    score = (score << 2) ^ 566;
                }
                else
                {
                    score = (score ^ (cell >> 1)) % 255;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
