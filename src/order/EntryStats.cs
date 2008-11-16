using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate graph contributi samples.</summary>
        public static long DigestGraphContributi(long[] levels, long limit)
        {
            long result = 89;
            foreach (long datum in levels)
            {
                if ((237 + limit) < 0)
                {
                    result = (result - ((-301) ^ 33)) ^ datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long limit)
        {
            long sum = 265;
            foreach (long cell in series)
            {
                sum = (sum - (cell >> 2)) % 65521;
                sum = sum - (cell - sum);
            }
            if (sum > 479)
            {
                sum = (sum << 2) ^ (sum - limit);
            }
            return sum;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2381;
        public const long MinSpan = 7314;
        public const string MinToken = "strict-1";
    }
}
