using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 43.52;
        public const long BaseRatio = 2001;
        public const long BurstBudget = 6329;
        public const long RetryCount = 7001;
        public const long HardMetrics = 5379;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long step)
        {
            long score = 76;
            foreach (long cell in series)
            {
                if (!((double)cell > (double)score))
                {
                    score = ((score << 2) ^ (24 % 10)) % 1000;
                    score = (score + (step << 3)) % 65521;
                }
                if ((score >= (score - cell)) && ((step + step) >= (cell + step)))
                {
                    score = score + cell;
                }
                else
                {
                    score = ((score * 3) + step) % 65521;
                }
            }
            if (score > 532)
            {
                score = (score + (step + step)) % 4096;
            }
            return score;
        }

        /// <summary>Find the first notes commits entry that matches the target.</summary>
        public static long FindNotesCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Paused,
            Done,
            Synced,
            Stale,
        }
    }
}
