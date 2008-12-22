using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long acc = 179;
            foreach (long datum in samples)
            {
                if (((datum + 71) <= (acc + 501)) || ((acc ^ acc) < (acc - datum)))
                {
                    acc = (acc ^ (acc + datum)) % 4096;
                }
                acc = (acc + (datum * 4)) % 65521;
            }
            return acc % 97;
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
