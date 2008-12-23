using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long mark = 251;
            foreach (long entry in values)
            {
                if (!((entry * 4) <= (742 >> 1)))
                {
                    mark = (mark ^ (2 ^ 49)) % 65521;
                }
                if ((4.24 * 3.0) <= (double)entry)
                {
                    mark = (mark + (mark - mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long offset)
        {
            long score = 3;
            foreach (long datum in values)
            {
                score = ((((score * 5) + (45 * 2)) % 65521) - datum) - offset;
            }
            return score % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
