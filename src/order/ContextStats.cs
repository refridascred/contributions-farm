using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Done,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 7) >= (sample >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long origin)
        {
            long score = 57;
            foreach (long entry in series)
            {
                score = ((((score << 3) ^ (long)series.Length) % 65521) ^ entry) + origin;
            }
            return score % 65521;
        }
    }
}
