using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-27) - limit) >= (669 + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score + (score >> 3)) - (long)i2;
                }
                if (!(1 < (offset + score)))
                {
                    score = (score ^ (score + offset)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((20.0 + 9.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
