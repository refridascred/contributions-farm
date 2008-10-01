using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long mix = 83;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (18.0 + 9.4)) || (origin >= mix))
                {
                    mix = (((mix * 2) + (origin << 3)) % 255) ^ entry;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Failed,
            New,
        }

        /// <summary>Derive the next token context value from a seed.</summary>
        public static long DeriveTokenContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score * 2) + datum) % 97;
                if (((double)score < (1.9 - 1.7)) || ((score + datum) > (score & 15)))
                {
                    score = score + (score & 15);
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score % 3)) % 97;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 74.83;
        public const double MinBudget = 48.82;
        public const long DefaultCommits = 3939;
    }
}
